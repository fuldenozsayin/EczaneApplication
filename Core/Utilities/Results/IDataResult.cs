using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Interfaceler bu şekilde implement ediliyor.
    public interface IDataResult<T>:IResult//IResult kim mesaj içersin ama aynı zamanda data içersin istediğimiz için ayrı bir class oluşturduk.
    {
        T Data { get; }
    }
}
