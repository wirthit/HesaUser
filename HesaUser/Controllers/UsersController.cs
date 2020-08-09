using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcUser.Data;
using System.Security.Cryptography.X509Certificates;

namespace MvcUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserDbContext _context;

        public UsersController(UserDbContext context)
        {
            _context = context;
        }

        // GET: api/Users/Filter
        [HttpGet("{filter}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(string filter)
        {
            return await _context.Users.Where(x => x.Surname.Contains(filter)).ToListAsync();
        }
    }
}
