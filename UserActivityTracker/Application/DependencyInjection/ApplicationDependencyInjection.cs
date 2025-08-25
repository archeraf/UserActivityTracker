using Microsoft.Extensions.DependencyInjection;
using UserActivityTracker.Application.Services;

namespace UserActivityTracker.Application.DependencyInjection
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<GithubApiService>();
            return services;
        }
    }
}
