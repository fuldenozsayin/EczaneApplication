using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string NationalityId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual User User { get; set; }//virtual ezilebilir prop demek. İçerisinde başka bir nesne alabileceğini belirtiyoruz.
    }
}
