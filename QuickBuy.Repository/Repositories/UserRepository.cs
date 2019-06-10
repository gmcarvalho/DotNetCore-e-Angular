

using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Entity;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() {
        }
    }
}
