using Newtonsoft.Json;
using System;

namespace ConferenceFunctions
{
    public class SessionOverview
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
