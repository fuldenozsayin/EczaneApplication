using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.OrderDetail
{
    internal class CreateOrderDetailRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? CourierId { get; set; }
    }
}
