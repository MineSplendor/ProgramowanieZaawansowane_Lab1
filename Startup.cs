using AdvancedProgramming_Lesson1.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1
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
            services.AddControllersWithViews();

            services.AddDbContext<MvcMovieContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            services.AddDbContext<MvcBookListContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcBookListContext")));

            services.AddDbContext<MvcPhoneContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcPhoneContext")));

            services.AddDbContext<MvcShoeContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcShoeContext")));

            services.AddDbContext<MvcKnifeContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcKnifeContext")));

            services.AddDbContext<MvcPlateContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcPlateContext")));

            services.AddDbContext<MvcGlassContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcGlassContext")));

            services.AddDbContext<MvcDrinkContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcDrinkContext")));

            services.AddDbContext<MvcMeatContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcMeatContext")));

            services.AddDbContext<MvcVegetableContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcVegetableContext")));
           
            services.AddDbContext<MvcGenreContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcGenreContext")));

            services.AddDbContext<MvcAuthorContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcAuthorContext")));

            services.AddDbContext<MvcAuthorsBookContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MvcAuthorsBookContext")));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
