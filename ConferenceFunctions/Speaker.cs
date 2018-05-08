using Newtonsoft.Json;
using System;

namespace ConferenceFunctions
{
    public class Speaker
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
