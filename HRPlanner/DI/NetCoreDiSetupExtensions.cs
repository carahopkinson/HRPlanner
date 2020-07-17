using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.DI
{
    public static class NetCoreDiSetupExtensions
    {
        public static void RegisterServiceLayerDi
            (this IServiceCollection services)
        {
            services.RegisterAssemblyPublicNonGenericClasses()
                .AsPublicImplementedInterfaces();

            //put any non-standard DI registration, e.g. generic types, here
        }
    }
}
