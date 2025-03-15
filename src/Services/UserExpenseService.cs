using System.Net;
using Luna.Ui.Models;

namespace Luna.Ui.Services
{
    public class UserExpenseService : IUserExpenseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserExpenseService(IHttpClientFactory httpClientFactory) =>
        _httpClientFactory = httpClientFactory;

        public async Task<HttpStatusCode> CreateUserExpenseAsync(Expense userExpense)
        {
            var client = _httpClientFactory.CreateClient("LunaAPI");

            var response = await client.PostAsJsonAsync<Expense>("/Expense", userExpense);

            return response.StatusCode;
        }
    }
}