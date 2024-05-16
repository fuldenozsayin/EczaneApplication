using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IReceiptService
    {
        IDataResult<List<Receipt>> GetAll();
        IDataResult<Receipt> GetById(int receiptId);

        IResult Add(Receipt receipt);
        IResult Update(Receipt receipt);
        IResult Delete(int receiptId);
    }
}
