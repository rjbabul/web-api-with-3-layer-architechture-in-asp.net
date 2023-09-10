using Microsoft.Extensions.DependencyInjection;
using MyTestApi.Repository;
using MyTestApi.Repository.Abstraction;
using MyTestApi.Service;
using MyTestApi.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApi.Configuration
{
    public class ApplicationConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IRepository, Repositories>();
            services.AddScoped<IServices, MyServices>();
        }
    }
}
