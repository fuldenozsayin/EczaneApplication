using Business.Abstracts;
using Business.Constants;
using Core.Entities.Concrete;
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
    public class StatusManager : IStatusService
    {
        IStatusDal _statusDal;
        public StatusManager(IStatusDal statusDal)
        {
            statusDal = _statusDal;
        }
        public IResult Add(Status status)
        {
            _statusDal.Add(status);
            return new SuccessResult(Messages.StatusAdded);
        }

        public IResult Delete(int statusId)
        {
            _statusDal.Delete(_statusDal.Get(c => c.StatusId == statusId));
            return new Result(true, Messages.StatusDeleted);
        }

        public IDataResult<List<Status>> GetAll()
        {
            return new SuccessDataResult<List<Status>>(_statusDal.GetAll());
        }

        public IDataResult<Status> GetById(int statusId)
        {
            return new SuccessDataResult<Status>(_statusDal.Get(c => c.StatusId == statusId));
        }

        public IResult Update(Status status)
        {
            _statusDal.Update(status);
            return new SuccessResult(Messages.StatusUpdated);
        }
    }
}
