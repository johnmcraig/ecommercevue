using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.Threading.Tasks;
using ecommercevue.Data.Entities;

namespace ecommercevue.Data.Entities
{
    public class DataSeeder
    {
        private readonly EcommerceDbContext _dbContext;

        public DataSeeder (EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SeedData(int users)
        {
            _dbContext.Database.EnsureCreated();

            if (!_dbContext.AppUsers.Any())
            {
                // _dbContext.AddRange(users);
                SeedUsers(users);
                await _dbContext.SaveChangesAsync();
            }
        }

        private void SeedUsers(int n)
        {
            List<AppUser> users = BuildUserList(n);

            foreach (var user in users)
            {
                _dbContext.AppUsers.AddAsync(user);
            }
        }

        private List<AppUser> BuildUserList(int nUsers)
        {
            var users = new List<AppUser>();
            var names = new List<string>();

            for (var i = 1; i <= nUsers; i++)
            {
                var name = DataSeedHelper.MakeUniqueUserNames(names);
                
                names.Add(name);

                users.Add(new AppUser
                {
                    Id = i,
                    FirstName = name,
                    Email = DataSeedHelper.MakeUserEmail(name),
                    EmailConfirmed = true,
                    LockoutEnabled = false
                });
            }

            return users;
        }

        // List<AppUser> users = new List<AppUser>()
        // {
        //      new AppUser()
        //      {
        //          FirstName = "Jon",
        //          LastName = "Doe",
        //          UserName = "default@example.com",
        //          Email = "default@exapmle.com",
        //          EmailConfirmed = true,
        //          LockoutEnabled = false
        //      }
        // };
    }
}