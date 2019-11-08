using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MiddlewareDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            // app.Map("/about", (appContext) => {
            //         appContext.Use(async (httpContext, next)=>{
            //             await httpContext.Response.WriteAsync("<br/> About - Middleware 1 request");
            //             await next.Invoke();
            //             await httpContext.Response.WriteAsync("<br/> About - Middleware 1 request");
            //         });
            //         appContext.Use(async (httpContext, next)=>{
            //             await httpContext.Response.WriteAsync("<br/> About - Middleware 2 response");
            //             await next.Invoke();
            //             await httpContext.Response.WriteAsync("<br/> About - Middleware 2 response");
            //         });
            //         appContext.Run(async (httpContext)=>{
            //              await httpContext.Response.WriteAsync("<h2>About Page</h2>");
            //         });
            // }); 
            // app.Map("/contact", (appContext) => {
            //         appContext.Use(async (httpContext, next)=>{
            //             await httpContext.Response.WriteAsync("<br/> contact - Middleware 1 request");
            //             await next.Invoke();
            //             await httpContext.Response.WriteAsync("<br/> contact - Middleware 1 response");
            //         });
            //         appContext.Use(async (httpContext, next)=>{
            //             await httpContext.Response.WriteAsync("<br/> contact - Middleware 2 request");
            //             await next.Invoke();
            //             await httpContext.Response.WriteAsync("<br/> contact - Middleware 2 response");
            //         });
            //         appContext.Use(async (httpContext, next)=>{
            //             await httpContext.Response.WriteAsync("<br/> contact - Middleware 3 request");
            //             await next.Invoke();
            //             await httpContext.Response.WriteAsync("<br/> contact - Middleware 3 response");
            //         });
            //         appContext.Run(async (httpContext)=>{
            //              await httpContext.Response.WriteAsync("<h2>contact Page</h2>");
            //         });
            // });    

            // app.Use(async (context, next) => {
            //     await context.Response.WriteAsync("<br/> Home - Middleware 1 request");
            //     await next.Invoke();
            //     await context.Response.WriteAsync("<br/> Home - Middleware 1 response");

            // }); 
            
            // app.MapWhen((context)=>context.Request.Query["lang"]=="en", (appContext)=>{
            //     appContext.Run(async (httpContext)=>{
            //              await httpContext.Response.WriteAsync("<h2>English Home Page</h2>");
            //      });
            // });            
            // app.MapWhen((context)=>context.Request.Query["lang"]== "hi", (appContext)=>{
            //     appContext.Run(async (httpContext)=>{
            //              await httpContext.Response.WriteAsync("<h2>Hindi Home Page</h2>");
            //      });
            // });

            app.UseMiddleware<SampleMiddleware>();
            app.UseSample();
            app.Run(async (context) => {
                await context.Response.WriteAsync("<br/>Default Home!");
            });
        }
    }
}
