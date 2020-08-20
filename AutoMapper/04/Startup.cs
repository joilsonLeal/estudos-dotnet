using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using _02.Model;
using System.Reflection;

namespace _02
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
            services.AddRazorPages();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<string, int>().ConvertUsing( s => Convert.ToInt32( s ) );
                cfg.CreateMap<string, DateTime>().ConvertUsing( new DateTimeConverter() );
                cfg.CreateMap<string, Type>().ConvertUsing<TypeTypeConverter>();
                cfg.CreateMap<Source, Destination>();
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }

    }

    public class DateTimeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert( string source, DateTime destination, ResolutionContext context )
        {
            return System.Convert.ToDateTime( source );
        }
    }

    public class TypeTypeConverter : ITypeConverter<string, Type>
    {
        public Type Convert( string source, Type destination, ResolutionContext context )
        {
            return Assembly.GetExecutingAssembly().GetType( source );
        }
    }
}
