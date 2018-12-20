using ecommercevue.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace ecommercevue.Data
{
    public static class DbContextExtensions
    {
        public static UserManager<AppUser> UserManager { get; set; }

        public static void EnsureSeeded(this EcommerceDbContext context)
        {
            if (UserManager.FindByEmailAsync("default@example.com").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser 
                {
                    FirstName = "Jon",
                    LastName = "Doe",
                    UserName = "default@example.com",
                    Email = "default@exapmle.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };

                UserManager.CreateAsync(user, "Password*").GetAwaiter().GetResult();
            }
        }
    }
}