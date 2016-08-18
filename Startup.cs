using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ThisDevelopersLife.Services;

namespace ThisDevelopersLife
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddIniFile("appsettings.ini");
            
            Configuration = builder.Build();
        }
        
        public IConfigurationRoot Configuration { get; set; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IShowService, InMemoryShowService>();
            
            services.Configure<AppSettings>(options => Configuration.GetSection("AppSettings").Bind(options));
            
            services
                .AddMvcCore()
                .AddViews()
                .AddRazorViewEngine()
                .AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            app.UseStatusCodePages();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStaticFiles();
            
            app.UseMvc();
        }
    }
}