using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ThisDevelopersLife.Models;
using ThisDevelopersLife.Services;

namespace ThisDevelopersLife
{
    public class Startup
    {       
        public Startup(IHostingEnvironment env)
        {
            Envirnoment = env;
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(Envirnoment.ContentRootPath)
                .AddIniFile("appsettings.ini");
            
            Configuration = builder.Build();
        }
        
        public IHostingEnvironment Envirnoment { get; set; }
        
        public IConfigurationRoot Configuration { get; set; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            if (Envirnoment.IsDevelopment())
            {
                services.AddDbContext<TDLContext>(options => options.UseInMemoryDatabase());
                services.AddTransient<IShowService, InMemoryShowService>();
            }
            else
            {
                services.AddDbContext<TDLContext>(options => options.UseSqlite("Filename=./TDL.db"));
                services.AddTransient<IShowService, SqLiteShowService>();
            }
            
            services.Configure<AppSettings>(options => Configuration.GetSection("AppSettings").Bind(options));
            
            services
                .AddMvcCore()
                .AddViews()
                .AddRazorViewEngine()
                .AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            app.UseStatusCodePages();

            if (Envirnoment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStaticFiles();
            
            app.UseMvc();
        }
    }
}