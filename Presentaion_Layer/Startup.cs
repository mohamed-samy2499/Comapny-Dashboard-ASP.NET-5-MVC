using Business_Logic_Layer.Interfaces;
using Business_Logic_Layer.Rpositories;
using Data_Access_Layer.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentaion_Layer.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentaion_Layer
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
            services.AddDbContext<AppDbContext>(options
                => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddScoped<IUnitOfWork , UnitOfWork>();
            services.AddScoped<IEmployeeRepository,EmployeeRepository>();
            services.AddScoped<IDepartmentRpository,DepartmentRepository>();
            services.AddScoped<ICityRepository, CityRpository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();


            services.AddAutoMapper(M=> M.AddProfile(new EmployeeProfile()));
            services.AddAutoMapper(M => M.AddProfile(new DepartmentProfile()));
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
