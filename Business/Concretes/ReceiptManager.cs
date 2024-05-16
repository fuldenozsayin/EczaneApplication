using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ReceiptManager : IReceiptService
    {
        IReceiptDal _receiptDal;
        public ReceiptManager(IReceiptDal receiptDal)
        {
            receiptDal = _receiptDal;
        }
        public IResult Add(Receipt receipt)
        {
            _receiptDal.Add(receipt);
            return new SuccessResult(Messages.ReceiptAdded);
        }

        public IResult Delete(int receiptId)
        {
            _receiptDal.Delete(_receiptDal.Get(c => c.ReceiptId == receiptId));
            return new Result(true, Messages.ReceiptDeleted);
        }

        public IDataResult<List<Receipt>> GetAll()
        {
            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll());
        }

        public IDataResult<Receipt> GetById(int receiptId)
        {
            return new SuccessDataResult<Receipt>(_receiptDal.Get(c => c.ReceiptId == receiptId));
        }

        public IResult Update(Receipt receipt)
        {
            _receiptDal.Update(receipt);
            return new SuccessResult(Messages.ReceiptUpdated);
        }
    }
}
