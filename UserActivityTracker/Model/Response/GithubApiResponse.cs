using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserActivityTracker.Model.Entities;

namespace UserActivityTracker.Model.Response
{
    public class GithubApiResponse
    {
        public GithubApiResponse(IEnumerable<Event> events)
        {
            Events = events;
        }

        public IEnumerable<Event> Events { get; set; }


    }
}
