using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserActivityTracker.Application.Services;

namespace UserActivityTracker.CliApp.Commands
{
    public class GetUserEventsCommand
    {
        private readonly GithubApiService _githubApiService;

        public GetUserEventsCommand(GithubApiService githubApiService)
        {
            _githubApiService = githubApiService ?? throw new ArgumentNullException(nameof(githubApiService));
        }

        public async Task ExecuteAsync(string username)
        {
            var response = await _githubApiService.GetUserEventsAsync(username);

            if (response?.Events == null || !response.Events.Any())
            {
                Console.WriteLine($"No events found for user {username}.");
                return;
            }

            response?.Events.ToList().ForEach(e =>
            {
                Console.WriteLine($"Event ID: {e.Id}, Type: {e.Type}, Created At: {e.CreatedAt}");
            });
        }
    }
}
