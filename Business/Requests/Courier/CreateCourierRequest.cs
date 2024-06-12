using Business.Requests.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Courier
{
    public class CreateCourierRequest
    {
        public int Id { get; set; }
        public CreateUserRequest CreateUserRequest { get; set; }
    }
}
