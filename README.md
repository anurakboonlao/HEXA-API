# Hexa Online Ordering Api
This project is develop with [asp.netcore 5.0](https://devblogs.microsoft.com/aspnet/announcing-asp-net-core-in-net-5/) for hexa online ordering api

## Prerequisites
- [.net sdk 5.0](https://dotnet.microsoft.com/download/dotnet-core/5.0)
- [ef-core tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
- [Docker](https://www.docker.com/products/docker-desktop)
- [mysql/mysql-server 8.0](https://hub.docker.com/r/mysql/mysql-server/)

## Developement environment setup

Start mysql service from docker
```
> cd Docker
> docker-compose up
```

Setup database connection and configuration from command line

```JSON
> cd HexaOnlineOrdering.Api
-> nano appsettings.Development.json
```

```json
"ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3310;database=db;uid=xxx;password=xxx",
    "EOrderConnection": "server=localhost;port=3310;database=db;uid=xxx;password=xxx",
    "WebMarketingConnection":"server=localhost;port=3310;database=db;uid=xxx;password=xxx"
}
```

Start the project with command line

```cmd
> cd HexaOnlineOrdering.Api dotnet run
```

Open your browser on : [http://localhost:5001/api](http://localhost:5001/api)

## Database Migration
### Create migration
Go to Api project
```cmd
> cd HexaOnlineOrdering.Api
> dotnet ef migrations add AddProductTable --context HexaDBContext
```

### Running migration
Go to Api project
```cmd
> cd HexaOnlineOrdering.Api
> dotnet ef database update --context HexaDBContext
```
### Migration naming convention
| Method | Naimg | Example |
| ------ | ------ |------ |
| Add | Add_{`table or event name`} | Add_Product |
| Update | Update_{`table or event name`} | Update_User |
| Drop | Drop_{`table or event name`} | Drop_Doctor |
| Seed | Seed_{`table or event name`} | Seed_User_UserRole_Data |

## Data Seeding
1. Inside [HexaOnlineOrdering.Repositories/Extensions/ModelBuilderExtensions.cs](/HexaOnlineOrdering.Api/HexaOnlineOrdering.Repositories/Extensions/ModelBuilderExtensions.cs) you can add code using [Fluent Api](https://docs.microsoft.com/en-us/ef/core/modeling/#use-fluent-api-to-configure-a-model) to create seed data
```csharp
   modelBuilder.Entity<TblUserRole>().HasData(
                new TblUserRole()
                {
                    Id = 1,
                    Name = "Dentist"
                },
                new TblUserRole()
                {
                    Id = 2,
                    Name = "Clinic"
                },
                new TblUserRole()
                {
                    Id = 3,
                    Name = "Admin"
                },
                new TblUserRole()
                {
                    Id = 4,
                    Name = "Staff"
                }
            );
```
2. Create a migration named with `Seed_{table_or_data_name}` for example,
```cmd
> dotnet ef migrations add Seed_UserRole --context HexaDBContext
```

3. Run Migration to apply the new change

## API Document
-[Swagger](https://localhost:5001/swagger/index.html)

## References
- [Cookie based authentication](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/cookie?view=aspnetcore-5.0)
- [Migrate from 3.1 to 5.0](https://docs.microsoft.com/en-us/aspnet/core/migration/31-to-50?view=aspnetcore-5.0&tabs=visual-studio)
- [asp.net core options pattern](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-5.0)
- [.Net code guideline](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)
- [EFCore migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
- [Filters](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-5.0)
- [AutoMapper](https://docs.automapper.org/en/latest/Dependency-injection.html#asp-net-core)