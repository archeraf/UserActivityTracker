using System.Text.Json.Serialization;

namespace UserActivityTracker.Model.Entities
{
    public class Commit
    {
        [JsonPropertyName("sha")]
        public string Sha { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("author")]
        public Author Author { get; set; }
    }
}