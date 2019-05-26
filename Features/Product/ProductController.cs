using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommercevue.Data;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult GetAll()
        {
            return Ok(_dbContext.Products.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok();
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