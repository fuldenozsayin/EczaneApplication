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
    public class CourierManager : ICourierService
    {
        ICourierDal _courierDal;
        public CourierManager(ICourierDal courierDal)
        {
            courierDal = _courierDal;
            
        }
        public IResult Add(Courier courier)
        {
            _courierDal.Add(courier);
            return new SuccessResult(Messages.CourierAdded);
        }

        public IResult Delete(int courierId)
        {
            _courierDal.Delete(_courierDal.Get(d=>d.CourierId==courierId));
            return new Result(true, Messages.CourierDeleted);
        }

        public IDataResult<List<Courier>> GetAll()
        {
            return new SuccessDataResult<List<Courier>>(_courierDal.GetAll());
        }

        public IDataResult<Courier> GetById(int courierId)
        {
            return new SuccessDataResult<Courier>(_courierDal.Get(c => c.CourierId == courierId));
        }

        public IResult Update(Courier courier)
        {
            _courierDal.Update(courier);
            return new SuccessResult(Messages.CourierUpdated);
        }
    }
}
