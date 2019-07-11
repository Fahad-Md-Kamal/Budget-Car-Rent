using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetCarRental.api.Data;
using BudgetCarRental.Model.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetCarRental.api
{
    public class Startup
    {
        public IConfiguration _Config { get; set; }

        public Startup(IConfiguration config)
        {
            _Config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AppDbContext>(x => x.UseSqlServer(_Config.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AppDbContext>(x => x.UseSqlite(_Config.GetConnectionString("DefaultConnection")));
            services.AddMvc();

            //services.AddIdentity<AppUser, IdentityRole>()
            //    .AddEntityFrameworkStores<AppDbContext>()
            //    .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
