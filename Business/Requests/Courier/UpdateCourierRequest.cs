using Business.Requests.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Courier
{
    public class UpdateCourierRequest
    {
        public int Id { get; set; }
        public UpdateUserRequest UpdateUserRequest { get; set; }
    }
}
