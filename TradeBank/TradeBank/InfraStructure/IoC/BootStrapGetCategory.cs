using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using TradeBank.Domain.Service;
using TradeBank.Service;

namespace TradeBank.InfraStructure.IoC
{
    public static class BootStrapGetCategory
    {
        public static IServiceCollection AddGetCategoryService(this IServiceCollection services, IConfiguration configuration)
        {
            _ = services ?? throw new ArgumentNullException(nameof(services));
            _ = configuration ?? throw new ArgumentNullException(nameof(configuration));

            bool.TryParse(configuration.GetSection("ApiConfiguration")["MockDeDados"], out bool mockDados);

//            if (mockDados)
//                services.AddSingleton<IClienteRepositorio, ClienteRepositorioMock>();
//            else
//                services.AddScoped<IClienteRepositorio, ClienteRepositorio>();

//            services.AddSingleton<IApiSerasa, ApiSerasa>();
//            services.AddSingleton<IEmailService, EmailService>();
            services.AddScoped<ITradeService, TradeService>();

            return services;
        }

    }
}
