using Core.CrossCuttingConcers.Caching;
using Core.CrossCuttingConcers.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolver
{
    public class CoreModule : ICoreModule
    {
        //Where service dependencies for the application will be resolved.
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache(); //IMemoryCache is inject.
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();  
        }
    }
}
