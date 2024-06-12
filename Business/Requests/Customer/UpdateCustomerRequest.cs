using Business.Requests.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Customer
{
    internal class UpdateCustomerRequest
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string NationalityId { get; set; }
        public string PhoneNumber { get; set; }

        public CreateUserRequest CreateUserRequest { get; set; }
    }
}
