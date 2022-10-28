using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    [Table("customer", Schema = "eticaret")]
    public class Customer : BaseEntity
    {
        public String Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}