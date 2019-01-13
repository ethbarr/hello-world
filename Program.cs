using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace hello_world
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

                //for info on adding config:
                //https://docs.microsoft.com/en-us/aspnet/core/migration/1x-to-2x/?view=aspnetcore-2.2#add-configuration-providers
    }
}
