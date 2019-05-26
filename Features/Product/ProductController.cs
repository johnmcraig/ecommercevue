using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommercevue.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Features.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly EcommerceDbContext _dbContext;

        public ProductController(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _dbContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> Get(string slug)
        {
            var product = await _dbContext.Products.SingleOrDefaultAsync(x => x.Slug == slug);
            
            if(product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost("")]
        public void Post([FromBody] string value)
        { 

        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        { 

        }

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        { 

        }
    }
}