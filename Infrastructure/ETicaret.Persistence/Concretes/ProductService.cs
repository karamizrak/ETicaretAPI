using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Abstractions;
using ETicaret.Domain.Entities;

namespace ETicaret.Persistence.Concretes
{
    internal class ProductService : IProductService
    {
        public List<Product> GetAllProducts() => new()
        {
            new() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Kalem0", Price = 1.5, Stock = 10 },
            new() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Kalem1", Price = 2.5, Stock = 12 },
            new() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Kalem2", Price = 3.5, Stock = 13 },
            new() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Kalem3", Price = 4.5, Stock = 14 },
            new() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Kalem4", Price = 5.5, Stock = 15 },
            new() { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Kalem5", Price = 6.5, Stock = 16 }
        };
    }
}