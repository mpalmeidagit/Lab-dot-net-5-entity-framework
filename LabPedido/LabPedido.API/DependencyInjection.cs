﻿using Microsoft.Extensions.DependencyInjection;

namespace LabPedido.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        private static void RepositoryDependence(IServiceCollection serviceProvider)
        {

        }
    }
}
