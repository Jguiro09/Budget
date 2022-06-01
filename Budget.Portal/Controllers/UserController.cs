using System.Collections.Generic;
using System.Linq;
using Budget.Portal.Database;
using Budget.Portal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Budget.Portal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly BudgetDbContext _context;

        public UserController(ILogger<UserController> logger, BudgetDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public User Get()
        {
            var query = _context.Users.FirstOrDefault<User>();
            return query;
        }
    }
}