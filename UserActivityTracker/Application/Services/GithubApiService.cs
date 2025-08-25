using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserActivityTracker.Application.Contracts;
using UserActivityTracker.Model.Response;

namespace UserActivityTracker.Application.Services
{
    public class GithubApiService
    {
        private readonly IGithubApiClient _githubApiClient;

        public GithubApiService(IGithubApiClient githubApiClient)
        {
            _githubApiClient = githubApiClient ?? throw new ArgumentNullException(nameof(githubApiClient));
        }

        public async Task<GithubApiResponse> GetUserEventsAsync(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username cannot be null or empty.", nameof(username));
            }
            return await _githubApiClient.GetEvents(username);
        }
    }
}
