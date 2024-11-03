using ClimaSprint2.Application.Services;
using ClimaSprint2.Data.AppData;
using ClimaSprint2.Data.Repositories;
using ClimaSprint2.Domain.Interfaces;
using ClimaSprint2.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClimaSprint2.IoC
{
    public class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(x => {
                x.UseOracle(configuration["ConnectionStrings:Oracle"]);
            });

            var apiKey = configuration["ApiSettings:WeatherApiKey"];

            services.AddTransient<IPrevisaoClimaService>(provider => new PrevisaoClimaService(apiKey));
            services.AddTransient<IPrevisaoClimaRepository, PrevisaoClimaRepository>();
            services.AddTransient<IClimaApplicationService, PrevisaoClimaApplicationService>();
        }
    }
}
