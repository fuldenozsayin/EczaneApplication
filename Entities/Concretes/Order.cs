using Core.Entities;
using Core.Entities.Concrete;
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
        public int CustomerId { get; set; } //veritabanın da string tuttuğu için ama biz yaparken int olması gerek
        public int? ReceiptId { get; set; }


        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Receipt Receipt { get; set; }

    }
}
