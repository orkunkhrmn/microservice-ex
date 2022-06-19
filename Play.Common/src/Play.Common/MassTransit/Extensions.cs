using Microsoft.Extensions.DependencyInjection;
using MassTransit;
using Play.Common.Settings;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using MassTransit.Definition;
using System;
using GreenPipes;

namespace Play.Common.MassTransit
{
    public static class Extensions
    {
        public static IServiceCollection AddMassTransitWithRabbitMq(this IServiceCollection services)
        {
            services.AddMassTransit(configure =>
            {
                configure.AddConsumers(Assembly.GetEntryAssembly());

                configure.UsingRabbitMq((context, configurator) =>
                {
                    var configuration = context.GetService<IConfiguration>();
                    // TODO: ayarları set etmek için
                    var serviceSettings = configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>();
                    var rabbitMQSettings = configuration.GetSection(nameof(RabbitMQSettings)).Get<RabbitMQSettings>();

                    configurator.Host(rabbitMQSettings.Host);
                    configurator.ConfigureEndpoints(context, new KebabCaseEndpointNameFormatter(serviceSettings.ServiceName, false));
                    configurator.UseMessageRetry(retryConfigurator =>
                    {
                        retryConfigurator.Interval(3, TimeSpan.FromSeconds(5)); // TODO eğer comsumerda hata oluşursa 3 kere 5 saniye aralıkla deneme yapar.
                    });
                });
            });

            services.AddMassTransitHostedService();


            return services;
        }
    }
}