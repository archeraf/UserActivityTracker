using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UserActivityTracker.Model.Entities
{
    public class Author
    {
        [JsonPropertyName("id")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }

    }
}
