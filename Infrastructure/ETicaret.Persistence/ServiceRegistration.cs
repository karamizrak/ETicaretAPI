using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Repositories.Customer;
using ETicaret.Application.Repositories.Order;
using ETicaret.Application.Repositories.Product;
using ETicaret.Persistence.Contexts;
using ETicaret.Persistence.Repositories.Customer;
using ETicaret.Persistence.Repositories.Order;
using ETicaret.Persistence.Repositories.Product;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<ETicaretApiDbContext>(options =>
            
                options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton
            );
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();

        }
    }
}