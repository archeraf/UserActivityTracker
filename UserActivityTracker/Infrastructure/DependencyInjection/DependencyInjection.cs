using Microsoft.Extensions.DependencyInjection;
using UserActivityTracker.Application.Contracts;
using UserActivityTracker.Infrastructure.Http;

namespace UserActivityTracker.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddHttpClient<IGithubApiClient, GithubApiClient>(client =>
            {
                client.BaseAddress = new Uri("https://api.github.com/");
                client.DefaultRequestHeaders.UserAgent.ParseAdd("cli-app");
            });

            return services;
        }
    }
}
