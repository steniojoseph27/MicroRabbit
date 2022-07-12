﻿using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
