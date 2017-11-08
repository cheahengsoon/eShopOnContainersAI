﻿using Catalog.API.AI;
using Catalog.API.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.API.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddAIServices(this IServiceCollection services)
        {
            services.AddTransient<IAzureMachineLearningService, AzureMachineLearningService>();
            services.AddTransient<IComputerVisionService, ComputerVisionService>();
            services.AddTransient<ICatalogTagsRepository, CatalogTagsRepository>();
            services.AddTransient<ICatalogTagsContextSeed, CatalogTagsContextSeed>();
            return services;
        }
    }
}