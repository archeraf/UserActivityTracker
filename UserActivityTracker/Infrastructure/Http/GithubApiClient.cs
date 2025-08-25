using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserActivityTracker.Application.Contracts;
using UserActivityTracker.Model.Entities;
using UserActivityTracker.Model.Response;

namespace UserActivityTracker.Infrastructure.Http
{
    public class GithubApiClient : IGithubApiClient
    {
        private readonly string _baseUrl = "https://api.github.com/";
        private readonly string _userAgent = "UserActivityTracker";
        private readonly HttpClient _httpClient;

        public GithubApiClient( HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GithubApiResponse> GetEvents(string username)
        {
            var url = $"{_baseUrl}users/{username.Trim()}/events/public";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", _userAgent);
                var response = client.GetAsync(url).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error fetching events for user {username}: {response.ReasonPhrase}");
                }
                var content = response.Content.ReadAsStringAsync().Result;
                var events = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Event>>(content);
                return new GithubApiResponse(events);
            }
        }
    }
}
