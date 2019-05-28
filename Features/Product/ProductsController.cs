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
    public class ProductsController : Controller
    {
        private readonly EcommerceDbContext _dbContext;

        public ProductsController(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Find()
        {
            var products = await _dbContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> Get(string slug)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Slug == slug);
            
            if(product == null)
                return NotFound();

            return Ok(product);
        }
    }
}