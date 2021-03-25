using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    //It provides the management of injections that we can use in different projects.
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
