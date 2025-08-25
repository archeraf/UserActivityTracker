using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserActivityTracker.Model.Response;

namespace UserActivityTracker.Application.Contracts
{
    public interface IGithubApiClient
    {
        Task<GithubApiResponse> GetEvents(string username);
    }
}
