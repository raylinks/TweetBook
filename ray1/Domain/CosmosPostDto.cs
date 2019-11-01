using System;
using Cosmonaut.Attributes;
using Newtonsoft.Json;

namespace ray1.Domain
{
    [CosmosCollection("posts")]
    public class CosmosPostDto
    {
        [CosmosPartitionKey]
        [JsonProperty("id")]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
