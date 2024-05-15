using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Seller:IEntity
    {
        public int SellerId { get; set; }
        public int UserId { get; set; }

        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        

        public virtual User User { get; set; }//virtual ezilebilir prop demek. İçerisinde başka bir nesne alabileceğini elirtiyoruz.
    }
}
