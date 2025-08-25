using System.Text.Json.Serialization;

namespace UserActivityTracker.Model.Entities
{
    public class Event
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("actor")]
        public Actor Actor { get; set; }
        [JsonPropertyName("repo")]
        public Repository Repository { get; set; }
        [JsonPropertyName("payload")]
        public Payload Payload { get; set; }
        [JsonPropertyName("public")]
        public bool Public { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
