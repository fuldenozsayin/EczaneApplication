using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Receipt:IEntity
    {
        public int ReceiptId { get; set; }
        

        public string ReceiptNumber { get; set;}

        
    }
}
