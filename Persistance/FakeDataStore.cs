using Domain.Entities;

namespace Persistance
{
    public class FakeDataStore
    {
        private static List<User> _vacancies;
        public FakeDataStore()
        {
            _vacancies = new List<User>
        {
            new User { Id =new Guid(), Description = "Test User 1" },
            new User { Id = new Guid(), Description = "Test User 2" },
            new User { Id = new Guid(), Description = "Test User 3" }
        };
        }
        public async Task AddUser(User User)
        {
            _vacancies.Add(User);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<User>> GetAllUsers() => await Task.FromResult(_vacancies);

        public async Task<User> GetUserId(Guid id) => await Task.FromResult(_vacancies.Single(p => p.Id == id));

        public async Task EventOccured(User User, string evt)
        {
            _vacancies.Single(u => u.Id == User.Id).Description = $"{User.Description} evt:{evt}";
            await Task.CompletedTask;
        }
    }
}