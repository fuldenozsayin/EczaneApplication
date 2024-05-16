using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IReceiptDetailService
    {
        IDataResult<List<ReceiptDetail>> GetAll();
        IDataResult<ReceiptDetail> GetById(int receiptDetailId);

        IResult Add(ReceiptDetail receiptDetail);
        IResult Update(ReceiptDetail receiptDetail);
        IResult Delete(int receiptDetailId);
    }
}
