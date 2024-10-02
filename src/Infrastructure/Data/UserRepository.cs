using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context) { }
    }
}
