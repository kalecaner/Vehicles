
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.BLL.Abstract;
using Vehicles.BLL.Concrate;
using Vehicles.Entity;
using Vehicles.Services;
using Vehicles.Services.Abstract;
using Vehicles.Services.Concrate;

namespace Vehicles
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
            services.AddDbContext<VehiclesDbContext>(opts =>
            { opts.UseSqlServer(Configuration.GetConnectionString("DataBaseContext"));
            });

            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBoatRepository, BoatRepository>();
            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();

            services.AddScoped<IColorService,ColorService>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IBoatService, BoatService>();
            services.AddScoped<IBusService, BusService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Vehicles", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Vehicles v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
