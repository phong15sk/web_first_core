using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Web_first_core_1
{
    public class Startup
    {
        public IConfiguration Configuration { get;  }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //app.Use(async(context, next) =>
            //{
            //    await context.Response.WriteAsync("</div> hello from the middleware 1 </div>");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("</div> Return from the middleware 1 </div>");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("</div> hello from the middleware 2 </div>");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("</div> Return from the middleware 2 </div>");
            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync(Configuration.GetSection("Message").Value);
            //    await context.Response.WriteAsync(Configuration.GetSection("ConnectionStrings:SQL").Value);
            //    await context.Response.WriteAsync(Configuration.GetSection("Student:0:name").Value);
            //    await context.Response.WriteAsync(Configuration.GetSection("arg1").Value);
            //});
        }
    }
}
