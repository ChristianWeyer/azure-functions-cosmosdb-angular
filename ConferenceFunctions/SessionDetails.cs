using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConferenceFunctions
{
    public class SessionDetails
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("speakers")]
        public List<Speaker> Speakers { get; set; }
        //public Slot TimeSlot { get; set; }
    }
}
