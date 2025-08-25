using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UserActivityTracker.Model.Entities
{
    public class Actor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("login")]
        public string Login { get; set; }
        [JsonPropertyName("display_login")]
        public string DisplayLogin { get; set; }
        [JsonPropertyName("gravatar_id")]
        public string GravatarId { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }
    }
}
