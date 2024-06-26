﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    [Table("products", Schema = "eticaret")]
    public class Product : BaseEntity
    {
        public String Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}