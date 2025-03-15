using Newtonsoft.Json;

namespace Luna.Ui.Models
{
    public class UserCard
    {
        [JsonProperty("planId")]
        public string? PlanId { get; set; }

        [JsonProperty("startDate")]
        public DateOnly? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateOnly? EndDate { get; set; }

        [JsonProperty("month")]
        public string? Month { get; set; }

        [JsonProperty("year")]
        public string? Year { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("currentBalance")]
        public decimal? CurrentBalance { get; set; }

        [JsonProperty("totalIncome")]
        public decimal? TotalIncome { get; set; }

        [JsonProperty("expensesPaid")]
        public decimal? ExpensesPaid { get; set; }

        [JsonProperty("expensesUnpaid")]
        public decimal? ExpensesUnpaid { get; set; }

        [JsonProperty("surplus")]
        public decimal? Surplus { get; set; }

        [JsonProperty("endingBalance")]
        public decimal? EndingBalance { get; set; }

        [JsonProperty("endingBalance")]
        public List<Income>? Incomes { get; set; }

        [JsonProperty("expenses")]
        public List<Expense>? Expenses { get; set; }
    }
}