using Newtonsoft.Json;

namespace Luna.Ui.Models
{
    public class Expense
    {
        [JsonProperty("id")]
        public string? id { get; set; }

        [JsonProperty("planId")]
        public string? PlanId { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("expenseDescription")]
        public string? ExpenseDescription { get; set; }

        [JsonProperty("expenseDueDate")]
        public DateOnly? ExpenseDueDate { get; set; }

        [JsonProperty("expenseStatus")]
        public bool ExpenseStatus { get; set; }

        [JsonProperty("user")]
        public string? User { get; set; }
    }
}