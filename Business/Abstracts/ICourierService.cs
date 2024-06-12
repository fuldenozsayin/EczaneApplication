using Business.Requests.Courier;
using Business.Responses.Courier;
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
        IDataResult<List<ListCourierResponse>> GetAll();
        IDataResult<Courier> GetById(int courierId);

        IResult Add(CreateCourierRequest request);
        IResult Update(UpdateCourierRequest request);
        IResult Delete(DeleteCourierRequest request
            );
    }
}
