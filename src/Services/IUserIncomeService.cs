using System.Net;
using Luna.Ui.Models;

namespace Luna.Ui.Services
{
    public interface IUserIncomeService
    {
        public Task<HttpStatusCode> CreateUserIncomeAsync(Income userIncome);
    }
}