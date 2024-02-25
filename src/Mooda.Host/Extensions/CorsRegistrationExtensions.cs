using Microsoft.AspNetCore.Builder;

namespace Mooda.Host.Extensions
{
    public static class CorsRegistrationExtensions
    {
        public static IApplicationBuilder UseCorsConfigurations(this IApplicationBuilder app)
        {
            app.UseCors();

            return app;
        }
    }
}