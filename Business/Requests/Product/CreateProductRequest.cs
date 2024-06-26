﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Product
{
    internal class CreateProductRequest
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int? SellerId { get; set; }

        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Description { get; set; }
    }
}
