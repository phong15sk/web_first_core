using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Web_first_core_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args)
        {
            var buider = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", true, true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);
                    //if (env.IsDevelopment())
                    //{
                    //    var appAssembly = Assembly.Load(new AssemblyName(env.EnvironmentName));
                    //    if (appAssembly != null)
                    //    {
                    //        config.AddUserSecrets(appAssembly, true);
                    //    }
                    //}
                    config.AddEnvironmentVariables();
                    if (args != null)
                    {
                        config.AddCommandLine(args);
                    }
                })
                .ConfigureLogging((hostingContext, Logging)=>
                {
                    Logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    Logging.AddConsole();
                    Logging.AddDebug();
                })
                .UseIISIntegration()
                .UseDefaultServiceProvider((Context, Options) => 
                {
                    Options.ValidateScopes = Context.HostingEnvironment.IsDevelopment();
                });
            return buider;
        }
    }
}
