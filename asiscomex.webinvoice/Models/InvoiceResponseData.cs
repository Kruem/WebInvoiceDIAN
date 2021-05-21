using Newtonsoft.Json;

namespace Asiscomex.Webinvoice.Models
{
    public class InvoiceResponseData
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("trackId")]
        public string TrackId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }
    }
}
