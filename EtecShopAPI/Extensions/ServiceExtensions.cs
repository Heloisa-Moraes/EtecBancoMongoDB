using MongoDB.Driver;

namespace EtecShopAPI.Extensions;

    public static class ServiceExtensions 
    {
        public static void ConfigureCors(this IServiceCollection services) 
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader() 
                );
            });

        }

        public static void ConfigureMongoDBSettings( this IServiceCollection services, IConfiguration config)
        {

        }
    }
