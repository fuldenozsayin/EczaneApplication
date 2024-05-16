using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class SellerManager : ISellerService
    {
        ISellerDal _sellerDal;
        public SellerManager(ISellerDal sellerDal)
        {
            sellerDal = _sellerDal;
        }
        public IResult Add(Seller seller)
        {
            _sellerDal.Add(seller);
            return new SuccessResult(Messages.SellerAdded);
        }

        public IResult Delete(int sellerId)
        {
            _sellerDal.Delete(_sellerDal.Get(c => c.SellerId == sellerId));
            return new Result(true, Messages.SellerDeleted);
        }

        public IDataResult<List<Seller>> GetAll()
        {
            return new SuccessDataResult<List<Seller>>(_sellerDal.GetAll());
        }

        public IDataResult<Seller> GetById(int sellerId)
        {
            return new SuccessDataResult<Seller>(_sellerDal.Get(c => c.SellerId == sellerId));
        }

        public IResult Update(Seller seller)
        {
            _sellerDal.Update(seller);
            return new SuccessResult(Messages.SellerUpdated);
        }
    }
}
