using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Product : BaseEntity
    {
        public String Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }
}