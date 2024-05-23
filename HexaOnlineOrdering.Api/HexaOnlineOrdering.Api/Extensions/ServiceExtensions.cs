using System;
using AutoMapper;
using HexaOnlineOrdering.Api.Mappings;
using HexaOnlineOrdering.Api.Services;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Repositories;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HexaOnlineOrdering.Api.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// The IServiceCollection extension for register all services
        /// </summary>
        /// <param name="services"></param>
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<INetforceService, NetforceService>();
            services.AddScoped<IHttpClientService, HttpClientService>();
            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<ICaseService, CaseService>();
            services.AddScoped<IAdvertiseService, AdvertiseService>();
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<IUserContactService, UserContactService>();
            services.AddScoped<IMarketingService, MarketingService>();
            services.AddScoped<IAWS3service, AWS3service>();
            services.AddScoped<IFileAttachmentService, FileAttachmentService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ISmsService, SmsService>();
            services.AddScoped<ILineService, LineService>();
            services.AddScoped<IRejectNoteService, RejectNoteService>();
            services.AddScoped<ICasePresentationHistoryService, CasePresentationHistoryService>();
        }

        /// <summary>
        /// The IServiceCollection extension for register all repositories
        /// </summary>
        /// <param name="services"></param>
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped<IMethodRepository, MethodRepository>();
            services.AddScoped<IOrderOverviewRepository, OrderOverviewRepository>();
            services.AddScoped<ICaseRepository, CaseRepository>();
            services.AddScoped<ICaseProductRepository, CaseProductRepository>();
            services.AddScoped<ICaseProductMaterialRepository, CaseProductMaterialRepository>();
            services.AddScoped<ICaseProductDesignRepository, CaseProductDesignRepository>();
            services.AddScoped<ICaseProductAddOnRepository, CaseProductAddOnRepository>();
            services.AddScoped<ICaseAttachedFileRepository, CaseAttachedFileRepository>();
            services.AddScoped<IAdvertiseRepository, AdvertiseRepository>();
            services.AddScoped<IFileAttachmentRepository, FileAttachmentRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IRejectNoteRepository, RejectNoteRepository>();
            services.AddScoped<ICasePresentationHistoryRepository, CasePresentationHistoryRepository>();

            // Marketing repo
            services.AddScoped<IMarketingMemberRepository, MarketingMemberRepository>();

            //Favorite
            services.AddScoped<IFavoriteRepository, FavoriteRepository>();
        }

        /// <summary>
        /// The IServiceCollection extension for register all mappings
        /// </summary>
        /// <param name="services"></param>
        public static void AddMappings(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new DomainToViewModelMappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
