using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ecommercevue.Data.Entities
{
    public class DataSeeder
    {
        private readonly EcommerceDbContext _dbContext;

        public DataSeeder (EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            _dbContext.Database.EnsureCreated();

            if (!_dbContext.AppUsers.Any())
            {
                _dbContext.AddRange(users);
                await _dbContext.SaveChangesAsync();
            }
        }

        List<AppUser> users = new List<AppUser>()
        {
             new AppUser()
             {
                 FirstName = "Jon",
                 LastName = "Doe",
                 UserName = "default@example.com",
                 Email = "default@exapmle.com",
                 EmailConfirmed = true,
                 LockoutEnabled = false
             }
        };
    }
}