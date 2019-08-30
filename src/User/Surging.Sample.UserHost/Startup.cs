using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Surging.Core.CPlatform.Runtime.Server;
using Surging.Core.CPlatform.Utilities;
using Surging.Core.ProxyGenerator;

namespace Surging.Sample.ServiceHost
{
    public class Startup
    {
        private readonly IConfigurationBuilder _configurationBuilder;
        private const string updateHostActionRoute = "v1/api/action/initactions";
        private const int hostNameSegmentLength = 3;

        public Startup(IConfigurationBuilder config)
        {
            _configurationBuilder = config;
        }

        public IContainer ConfigureServices(ContainerBuilder builder)
        {
            var services = new ServiceCollection();
            builder.Populate(services);
            ServiceLocator.Current = builder.Build();
            return ServiceLocator.Current;
        }

        public void Configure(IContainer app)
        {
        }

     
       
    }
}