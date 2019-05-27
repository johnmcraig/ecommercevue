using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.Threading.Tasks;
using ecommercevue.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace ecommercevue.Data.Entities
{
    public class DataSeeder
    {
        private readonly EcommerceDbContext _dbContext;

        public DataSeeder(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public static UserManager<AppUser> UserManager { get; set; }

        public async Task SeedData()
        {
            await _dbContext.Database.EnsureCreatedAsync();

            if (!_dbContext.AppUsers.Any())
            {
                SeedUser();
                await _dbContext.SaveChangesAsync();
            }

            if(!_dbContext.Products.Any())
            {
                SeedProducts();
                await _dbContext.SaveChangesAsync();
            }

        }
        private void SeedUser()
        {
            if (UserManager.FindByEmailAsync("default@example.com").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser
                {
                    FirstName = "John",
                    LastName = "Johnson",
                    UserName = "default@example.com",
                    Email = "default@exapmle.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };

                UserManager.CreateAsync(user, "Password1*").GetAwaiter().GetResult();
            }
        }

        private void SeedProducts()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Name = "Samsung Galaxy 8",
                    Slug = "samsung-galaxy-s8",
                    Thumbnail = "http://placehold.it/200x300",
                    ShortDescription = "Samsung Galaxy S8 Android",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    Price = 499.99M
                }
            };

            _dbContext.Products.AddRangeAsync(products);
            // _dbContext.SaveChangesAsync();
        }
    }
}