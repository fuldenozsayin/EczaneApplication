﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId{ get; set; } //veritabanın da string tuttuğu için ama biz yaparken int olması gerek
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
