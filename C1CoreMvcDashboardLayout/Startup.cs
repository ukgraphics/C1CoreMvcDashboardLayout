using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace C1CoreMvcDashboardLayout
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            C1.Web.Mvc.LicenseManager.Key = "c1v01xI/CqMaGwrcdxYHDs8K/RMS4wprDtcS8ecWfw6nEvnnCpDRVxZnCgMKUw6xUxY0xw4dZxJrDoHXFhMSwxYPCo8S3xI7CsMSnxI7EpsOMVcSSw7zCqcK2xYjCunLDmMOCwqfFhMKPwqPDscOBwoHFlsK8xLnEgcOtZFLCrsO2w5J8wqTFmcKHw4VXxYnCvmfEnMSdwqjDmnPCs8WqwqjFhMKjTsSpwrjFtcSow4TDq8KwxL5WxIjDm2B0xLXFoMKSW8Wee8SnSsOOc8Kfw53Ek8STxIDCk8KExZrCmMSNxa/Er8KUxJPEgMWpw7h4woLFgMKgw5zDssOLR8OVw4vFicSGxIXEhcSIxKPDksS4w4h0wrrDl3vEhcOxw6bFoMWKwqDEqMKk";
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
