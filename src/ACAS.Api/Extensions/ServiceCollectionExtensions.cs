using ACAS.Application.Services;
using ACAS.Infrastructure.Services;

namespace ACAS.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDI(this IServiceCollection services)
        {
            services.AddScoped<IDateTimeService, DateTimeService>();
        }
    }
}
