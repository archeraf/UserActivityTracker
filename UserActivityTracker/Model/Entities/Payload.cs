using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UserActivityTracker.Model.Entities
{
    public class Payload
    {
        [JsonPropertyName("repository_id")]
        public int RepositoryId { get; set; }

        [JsonPropertyName("push_id")]
        public long PushId { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("distinct_size")]
        public int DistinctSize { get; set; }

        [JsonPropertyName("ref")]
        public string Ref { get; set; }

        [JsonPropertyName("head")]
        public string Head { get; set; }

        [JsonPropertyName("before")]
        public string Before { get; set; }

        [JsonPropertyName("commits")]
        public List<Commit> Commits { get; set; }
    }
}
