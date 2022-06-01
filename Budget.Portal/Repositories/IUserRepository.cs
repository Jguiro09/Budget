using System.Collections.Generic;
using Budget.Portal.Models;

namespace Budget.Portal.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}