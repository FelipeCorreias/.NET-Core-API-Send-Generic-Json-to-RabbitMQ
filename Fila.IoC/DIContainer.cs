using Fila.Application.Interfaces;
using Fila.Application.Messages.Commands.SendMessage;
using Fila.Application.Settings;
using Fila.Common.Serializations;
using Fila.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.IoC
{
    public static class DIContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            //INFRASTRUCUTURE
            services.AddScoped<IMessageQueueingService, MessageQueueingService>();

            //APPLICATION
            // COMMANDS
            services.AddTransient<ISendMessageCommand, SendMessageCommand>();

            //SETTINGS
            services.AddTransient<IMessageQueueingSettings, MessageQueueingSettings>();

            // COMMON
            services.AddTransient<ISerializationService, SerializationService>();

        }
    }
}
