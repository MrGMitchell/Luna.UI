using Luna.Ui.Models;

namespace Luna.Ui.Services
{
    public interface IUserCardService
    {
        public Task<IEnumerable<UserCard>> GetUserCardsAsync();
    }
}