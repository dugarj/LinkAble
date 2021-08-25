using LABLL;
using LABOL;
using LADAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAUI
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
            //services.AddRazorPages();

            //services.RegisterBLLServices();

            #region BLL Services
            services.AddTransient<ICategoryBs, CategoryBs>();
            services.AddTransient<ILAUrlBs, LAUrlBs>();
            //services.AddTransient<IUserBs, UserBs>();
            #endregion

            #region DAL Services
            services.AddTransient<ICategoryDb, CategoryDb>();
            services.AddTransient<ILAUrlDb, LAUrlDb>();
            //services.AddTransient<IUserDb, UserDb>();
            #endregion


            services.AddDbContext<LADbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LAConString")));
            //services.AddDbContext<LADbContext>();

            services.AddIdentity<LAUser, IdentityRole>().AddEntityFrameworkStores<LADbContext>().AddDefaultTokenProviders();
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

            services.AddMvc(x => x.Filters.Add(new AuthorizeFilter(policy)));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Categories}/{action=Index}/{id?}");
            });
        }
    }
}
