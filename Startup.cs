using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace hello_world
{
    public class Startup
    {
      public Startup(IConfiguration configuration)
      {
          //1.0 -> 2.0: https://docs.microsoft.com/en-us/aspnet/core/migration/1x-to-2x/?view=aspnetcore-2.2#add-configuration-providers
          //2.0 -> 2.1: https://docs.microsoft.com/en-us/aspnet/core/migration/20_21?view=aspnetcore-2.2#changes-to-startup
      }        
       
      public void Configure(IApplicationBuilder app, 
        IHostingEnvironment env, ILoggerFactory loggerFactory)
      {
        app.Run(async (context) =>
        {
          await context.Response.WriteAsync("Hello, world!");
        });
      }
    }
}