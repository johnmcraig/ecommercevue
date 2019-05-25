using System.Threading.Tasks;
using ecommercevue.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Features.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly EcommerceDbContext _dbContext;
        
        public UsersController(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.AppUsers.ToListAsync());
        }

    }
}