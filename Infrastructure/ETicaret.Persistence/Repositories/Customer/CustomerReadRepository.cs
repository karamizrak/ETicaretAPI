using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Repositories.Customer;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Customer
{
    internal class CustomerReadRepository:ReadRepository<Domain.Entities.Customer>,ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretApiDbContext context) : base(context)
        {
        }
    }
}
