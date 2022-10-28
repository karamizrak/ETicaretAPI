using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    [Table("orders", Schema = "eticaret")]
    public class Order : BaseEntity
    {
        public String Description { get; set; }
        public String Address { get; set; }
        public ICollection<Product> Products { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}