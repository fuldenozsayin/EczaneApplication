using Business.Abstracts;
using Business.Constants;
using Castle.Core.Resource;
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
    public class ReceiptDetailManager : IReceiptDetailService
    {
        IReceiptDetailDal _receiptDetailDal;
        public ReceiptDetailManager(IReceiptDetailDal receiptDetailDal)
        {
            receiptDetailDal = _receiptDetailDal;
        }

        public IResult Add(ReceiptDetail receiptDetail)
        {
            _receiptDetailDal.Add(receiptDetail);
            return new SuccessResult(Messages.ReceiptDetailAdded);
        }

        public IResult Delete(int receiptDetailId)
        {
            _receiptDetailDal.Delete(_receiptDetailDal.Get(c => c.ReceiptDetailId == receiptDetailId));
            return new Result(true, Messages.ReceiptDetailDeleted);
        }

        public IDataResult<List<ReceiptDetail>> GetAll()
        {
            return new SuccessDataResult<List<ReceiptDetail>>(_receiptDetailDal.GetAll());
        }

        public IDataResult<ReceiptDetail> GetById(int receiptDetailId)
        {
            return new SuccessDataResult<ReceiptDetail>(_receiptDetailDal.Get(c => c.ReceiptDetailId == receiptDetailId));
        }

        public IResult Update(ReceiptDetail receiptDetail)
        {
            _receiptDetailDal.Update(receiptDetail);
            return new SuccessResult(Messages.ReceiptDetailUpdated);
        }
    }
}
