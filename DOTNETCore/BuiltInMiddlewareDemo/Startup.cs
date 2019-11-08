using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace BuiltInMiddlewareDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            var options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("hello.html");
            app.UseDefaultFiles(options);

            // var fileOptions = new DefaultFilesOptions();
            // //fileOptions.DefaultFileNames.Clear();
            // //fileOptions.DefaultFileNames.Add("index.html");
            // fileOptions.RequestPath="/files";
            // fileOptions.FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "files"));
            // app.UseDefaultFiles(fileOptions);

            // app.UseStaticFiles(new StaticFileOptions(){
            //     RequestPath="/files",
            //     FileProvider= new PhysicalFileProvider(
            //         Path.Combine(Directory.GetCurrentDirectory(), "files"))
            // });

            app.UseFileServer(new FileServerOptions(){
                RequestPath="/files",
                EnableDirectoryBrowsing=true,
                FileProvider= new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "files"))
                
            });


            app.UseStaticFiles(); // For wwwroot
            // app.UseDirectoryBrowser(new DirectoryBrowserOptions(){
            //     RequestPath="/files",
            //     FileProvider= new PhysicalFileProvider(
            //         Path.Combine(Directory.GetCurrentDirectory(), "files"))
            // });
            app.UseCookiePolicy();

            // app.UseMvcWithDefaultRoute(); for default route we can write single line but if you want to built some route so you can use blow syntax.

            app.UseMvc(routes =>
            {
                // routes.MapRoute(
                //     name: "ProductRoute",
                //     template: "admin/products/{action=Index}/{id?}"
                // )

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
