using System;
using Mooda.Api.Configurations;
using Mooda.Domain.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mooda.Host.Extensions
{
    public static class OptionsRegistrationExtensions
    {
        public static IServiceCollection AddOptions(this IServiceCollection services,
                                                    IConfiguration configuration,
                                                    Action<DbConnectionStrings> connectionString)
        {
            services.Configure<AuthTokenOptions>(configuration.GetSection("Auth"));

            services
                .AddOptions<DbConnectionStrings>()
                .Configure(connectionString)
                .ValidateDataAnnotations();

            return services;
        }
    }
}