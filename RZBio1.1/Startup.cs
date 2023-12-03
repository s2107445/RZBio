using Microsoft.EntityFrameworkCore;
using RZBio1._1.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RZBio1._1
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }



        public void ConfigureServices (IServiceCollection services)
        {
            //DbContext Configuration
            services.AddDbContext<CinemaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectiontring")));

            services.AddControllersWithViews();
        }

        //Saknar Configure lägg till här sen.
    }
}
