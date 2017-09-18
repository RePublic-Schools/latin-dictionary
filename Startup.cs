using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using LatinDictionaryNoAuth.Data;

namespace LatinDictionaryNoAuth
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            // string path = System.Environment.GetEnvironmentVariable("LatinDictionaryNoAuth_Db_Path");
            string path = "/Users/dwendling/workspace/LatinDictionaryNoAuth/Data/latinDictionaryNoAuth.db";
            var connection = $"Filename={path}";
            Console.WriteLine($"connection = {connection}");
            services.AddDbContext<LatinDictionaryWebContext>(options => options.UseSqlite(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         string sqliteConnectionString = null;

        //         try
        //         {
        //             var connectionString = new SqliteConnectionStringBuilder()
        //             {
        //                 DataSource = Path.Combine(ApplicationData.Current.LocalFolder.Path, "LatinDictionaryNoAuth.db")
        //             };
        //             sqliteConnectionString = connectionString.ToString();
        //         }
        //         catch (InvalidOperationException)
        //         {
        //             var connectionString = new SqliteConnectionStringBuilder()
        //             {
        //                 DataSource = "LatinDictionaryNoAuth.db"
        //             };
        //             sqliteConnectionString = connectionString.ToString();
        //         }

        //         optionsBuilder.UseSqlite(sqliteConnectionString);
        //     }
        // }
    }
}
