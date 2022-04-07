using Airports.Aplication.AirportApi;
using Airports.Aplication.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airports.Aplication
{
    public static class ApplicationDependencies
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            var assembliesToScan = typeof(ApplicationDependencies).Assembly;
            services.AddMediatR(assembliesToScan);
            services.AddHttpClient<IAirportApiClient, AirportApiClient>(x =>
                x.BaseAddress = new Uri(configuration.GetSection("AirportApi")["Url"]));

            services.AddTransient<IAirportService, AirportService>();
        }
    }
}
