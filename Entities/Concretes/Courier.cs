using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Courier:IEntity
    {
        public int CourierId { get; set; }
        public int UserId { get; set; }
        

        public virtual User User { get; set; }
        
    }
}
