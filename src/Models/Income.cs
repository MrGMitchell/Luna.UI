using Newtonsoft.Json;

namespace Luna.Ui.Models
{
    public class Income
    {
        [JsonProperty("id")]
        public string? id { get; set; }

        [JsonProperty("planId")]
        public string? PlanId { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("payDate")]
        public DateOnly? PayDate { get; set; }

        [JsonProperty("user")]
        public string? User { get; set; }
    }
}