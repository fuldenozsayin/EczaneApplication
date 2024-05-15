using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ReceiptDetail:IEntity
    {
        public int ReceiptDetailId { get; set; }
        public int ReceiptId { get; set; }
        public int ProductId { get; set; }
        //ReceiptDetail:{   }
        //?
        public virtual Receipt Receipt { get; set; }
        public virtual Product Product { get; set; }
    }
}
