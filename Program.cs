using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ecommercevue.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ecommercevue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var host = BuildWebHost(args);
            // using (var scope = host.Services.CreateScope())
            // {
            //     var services = scope.ServiceProvider;
            //     var dbContext = services.GetRequiredService<EcommerceDbContext>();
            //     dbContext.Database.Migrate();
            //     dbContext.EnsureSeeded();
            // }

            // host.Run();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
