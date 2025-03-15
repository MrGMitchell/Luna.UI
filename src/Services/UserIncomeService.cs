using System.Net;
using Luna.Ui.Models;

namespace Luna.Ui.Services
{
    public class UserIncomeService : IUserIncomeService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserIncomeService(IHttpClientFactory httpClientFactory) =>
        _httpClientFactory = httpClientFactory;

        public async Task<HttpStatusCode> CreateUserIncomeAsync(Income userIncome)
        {
            var client = _httpClientFactory.CreateClient("LunaAPI");

            var response = await client.PostAsJsonAsync<Income>("/Income", userIncome);

            return response.StatusCode;
        }
    }
}