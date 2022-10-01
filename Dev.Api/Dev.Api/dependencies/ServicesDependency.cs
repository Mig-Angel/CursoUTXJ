using Dev.Business.Business;
using Dev.Business.IBusiness;
using Dev.Data.IRepository;
using Dev.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Api.dependencies
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
            services.AddScoped<IProductoBusiness ,ProductoBusiness>();
        }
    }
}
