using System.Collections.Generic;
using System.Linq;
using Budget.Portal.Database;
using Budget.Portal.Models;

namespace Budget.Portal.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BudgetDbContext _context;

        public UserRepository(BudgetDbContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList<User>();
        }
    }
}