using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SEDC.AspNet.Homework.Class02.App
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //// PART ONE ROUTES
                //routes.MapRoute(
                //    name: "test_product_route",
                //    template: "product/get-product/{id:int}",
                //    defaults: new { controller = "Product", action = "GetProductById" });

                //routes.MapRoute(
                //    name: "test_product_route2",
                //    template: "product/get-product/{id:alpha}",
                //    defaults: new { controller = "Product", action = "GetProductByName" });

                //// PART TWO ROUTES
                //routes.MapRoute(
                //    name: "test_movie_route",
                //    template: "homework/movie/get-movies/{releasedate:datetime}",
                //    defaults: new { controller = "Movie", action = "GetMovieByDateTime" });

                //routes.MapRoute(
                //    name: "test_movie_route2",
                //    template: "homework/movie/get-available/{isavailable:bool}",
                //    defaults: new { controller = "Movie", action = "GetMovieByAvailable" });

                //// BONUS ROUTE
                //routes.MapRoute(
                //    name: "test_order_route2",
                //    template: "pizza/order/create-order/",
                //    defaults: new { controller = "Order", action = "CreateOrder"});
            });
        }
    }
}
