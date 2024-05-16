using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourierService
    {
        IDataResult<List<Courier>> GetAll();
        IDataResult<Courier> GetById(int courierId);

        IResult Add(Courier courier);
        IResult Update(Courier courier);
        IResult Delete(int courierId);
    }
}
