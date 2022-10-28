using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Repositories.Order;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Order
{
    internal class OrderWriteRepository:WriteRepository<Domain.Entities.Order>,IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretApiDbContext context) : base(context)
        {
        }
    }
}
