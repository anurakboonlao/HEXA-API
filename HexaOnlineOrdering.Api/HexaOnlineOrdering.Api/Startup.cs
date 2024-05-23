using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using HexaOnlineOrdering.Api.Extensions;
using HexaOnlineOrdering.Api.Filters;
using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Repositories.DataAccess;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.EOrderDataModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddHttpClient();
            services.AddHttpContextAccessor();

            // Config Database
            string defaultConn = Configuration.GetConnectionString("DefaultConnection");
            string eOrderConn = Configuration.GetConnectionString("EOrderConnection");
            string marketingConn = Configuration.GetConnectionString("WebMarketingConnection");


            // Config AWS3  and service
            string aws3Conn = Configuration.GetConnectionString("AWS3");
            services.Configure<AWS3setting>(Configuration.GetSection(AWS3setting.SECTION));

            services.AddDbContext<HexaDBContext>(options =>
                options.UseMySql(defaultConn, ServerVersion.AutoDetect(defaultConn))
            ).AddDbContext<EOrderDBContext>(options =>
                options.UseMySql(eOrderConn, ServerVersion.AutoDetect(eOrderConn))
            ).AddDbContext<MarketingDBContext>(options =>
                options.UseMySql(marketingConn, ServerVersion.Parse("10.4.11-mariadb"))
            );


            // Options configuration
            services.Configure<JWTSetting>(Configuration.GetSection(JWTSetting.SECTION));
            services.Configure<NetforceSetting>(Configuration.GetSection(NetforceSetting.SECTION));
            services.Configure<MarketingSetting>(Configuration.GetSection(MarketingSetting.SECTION));

            services.Configure<Mode>(Configuration.GetSection(Mode.SECTION));
            services.Configure<EmailSetting>(Configuration.GetSection(EmailSetting.SECTION));
            services.Configure<SmsSetting>(Configuration.GetSection(SmsSetting.SECTION));
            services.Configure<HostSetting>(Configuration.GetSection(HostSetting.SECTION));
            services.Configure<LineConfiguration>(Configuration.GetSection(LineConfiguration.SECTION));
            services.Configure<PdfSetting>(Configuration.GetSection(PdfSetting.SECTION));

            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
                var dateConverter = new Newtonsoft.Json.Converters.IsoDateTimeConverter
                {
                    DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'"
                };

                options.SerializerSettings.Converters.Add(dateConverter);
                options.SerializerSettings.Culture = new CultureInfo("en-IE");
                options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            });

            // Authentication services.
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["JwtConfig:Issuer"],
                        ValidAudience = Configuration["JwtConfig:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtConfig:Secret"])),

                        // None issuer validation
                        //ValidateIssuerSigningKey = true,
                        //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtConfig:Secret"])),
                        //ValidateIssuer = false,
                        //ValidateAudience = false,
                        //ValidateLifetime = true,
                        //RequireExpirationTime = false,
                    };

                })
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.Cookie.Name = "hexa-creds";
                    options.Cookie.HttpOnly = true;
                    options.Cookie.IsEssential = true;
                    //options.DataProtectionProvider = DataProtectionProvider.Create(new DirectoryInfo("/Users/sooparerk/Desktop/Projects/apollo21/Hexa/hexa-online-ordering-api/SharedKey"));
                });

            // Filters
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(typeof(HttpGlobalExceptionFilter));
            });

            services.AddRepositories();
            services.AddServices();
            services.AddMappings();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(setup =>
            {
                setup.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Hexa Online Ordering API Documents",
                    Description = "An Open API for Hexa Online Ordering allow on development mode only"
                });

                // Include 'SecurityScheme' to use JWT Authentication
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Description = "JWT Authorization header using the Bearer scheme, put only your token",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecurityScheme, Array.Empty<string>() }
                });

                setup.OperationFilter<HeaderFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/hexa-api-{Date}.txt");
        
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Enable middleware to serve generated Swagger as a JSON endpoint.
                app.UseSwagger();

                // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
                // specifying the Swagger JSON endpoint.
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hexa Online Ordering API");
                });
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
