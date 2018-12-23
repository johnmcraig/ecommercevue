using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace ecommercevue.Data.Entities
{
    public class DataSeeder
    {
        private readonly EcommerceDbContext _dbContext;
        private readonly IHostingEnvironment _hosting;

        public DataSeeder (EcommerceDbContext dbContext, IHostingEnvironment hosting)
        {
            _dbContext = dbContext;
            _hosting = hosting;
        }

        public void Seed()
        {
            _dbContext.Database.EnsureCreated();

            if (!_dbContext.AppUsers.Any())
            {
                // Need to create sample data
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/users.json");
                var json = File.ReadAllText(filepath);
                var users = JsonConvert.DeserializeObject<IEnumerable<AppUser>>(json);

                _dbContext.AppUsers.AddRange(users);

                _dbContext.SaveChanges();
            }
        }
    }
}