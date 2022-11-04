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
                    options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Scoped
            );
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        }
    }
}