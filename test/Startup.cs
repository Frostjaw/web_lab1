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

namespace test
{
    public class CalcService
    {
        private readonly double firstNumber;
        private readonly double secondNumber;

        public CalcService()
        {
            Random random = new Random();
            firstNumber = random.Next(0, 10);
            secondNumber = random.Next(0, 10);
        }
        public double getFirstNumber()
        {
            return firstNumber;
        }
        public double getSecondNumber()
        {
            return secondNumber;
        }
        public double getSum()
        {
            return firstNumber + secondNumber;
        }
        public double getSub()
        {
            return firstNumber - secondNumber;
        }
        public double getMult()
        {
            return firstNumber * secondNumber;
        }
        public double getDiv()
        {
            if (secondNumber!=0) return firstNumber / secondNumber;
            return Double.NaN;
        }
    }

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<CalcService>();
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
            //app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
