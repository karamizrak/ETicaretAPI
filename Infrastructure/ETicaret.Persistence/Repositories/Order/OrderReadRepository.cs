using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Repositories.Order;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories.Order
{
    internal class OrderReadRepository:ReadRepository<Domain.Entities.Order>,IOrderReadRepository
    {
        public OrderReadRepository(ETicaretApiDbContext context) : base(context)
        {
        }
    }
}
