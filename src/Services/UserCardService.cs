using Luna.Ui.Models;

namespace Luna.Ui.Services
{
    public class UserCardService : IUserCardService
    {
        public IEnumerable<UserCard>? userCards { get; set; }

        private readonly IHttpClientFactory _httpClientFactory;
        public UserCardService(IHttpClientFactory httpClientFactory) =>
        _httpClientFactory = httpClientFactory;

        public async Task<IEnumerable<UserCard>> GetUserCardsAsync()
        {
            var client = _httpClientFactory.CreateClient("LunaAPI");

            userCards = await client.GetFromJsonAsync<List<UserCard>>("UserCard");

            return userCards ?? [];
        }
    }
}