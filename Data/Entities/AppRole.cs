using Microsoft.AspNetCore.Identity;

namespace ecommercevue.Data.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole() {}
        public AppRole(string name)
        {
            Name = name;
        }
    }
}