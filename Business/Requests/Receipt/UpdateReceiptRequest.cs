using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Receipt
{
    internal class UpdateReceiptRequest
    {
        public int ReceiptId { get; set; }
        public string ReceiptNumber { get; set; }
    }
}
