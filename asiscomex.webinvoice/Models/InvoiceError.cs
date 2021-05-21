using Newtonsoft.Json;

namespace Asiscomex.Webinvoice.Models
{
    public class InvoiceError
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("trackId")]
        public string TrackId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorReason")]
        [JsonConverter(typeof(CustomArrayConverter<string>))]
        public string[] ErrorReason { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }
    }
}
