﻿using Business.Requests.OrderDetail;
using Business.Requests.Receipt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Order
{
    internal class UpdateOrderRequest
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }

        public UpdateOrderDetailRequest UpdateOrderDetailRequest { get; set; }
        public UpdateReceiptRequest UpdateReceiptRequest { get; set; }
    }
}
