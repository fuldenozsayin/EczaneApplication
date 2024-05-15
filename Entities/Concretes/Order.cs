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
        public string CustomerId{ get; set; } //veritabanın da string tuttuğu için ama biz yaparken int olması gerek
        public int CourierId { get; set; }
        public int ReceiptId { get; set; }
        public int StatusId { get; set; }

        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }

        //?
        
        public virtual Status Status { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Courier Courier { get; set; }
        public virtual Receipt Receipt { get; set; }
        
    }
}
