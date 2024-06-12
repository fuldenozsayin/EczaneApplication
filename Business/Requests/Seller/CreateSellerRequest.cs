using Business.Requests.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Seller
{
    internal class CreateSellerRequest
    {
        public int Id { get; set; }

        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public CreateUserRequest CreateUserRequest { get; set; }
    }
}
