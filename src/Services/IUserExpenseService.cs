using System.Net;
using Luna.Ui.Models;

namespace Luna.Ui.Services
{
    public interface IUserExpenseService
    {
        public Task<HttpStatusCode> CreateUserExpenseAsync(Expense userExpense);
    }
}