using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //result bu class ın base classı
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success,message)//result this dediği için burada demedik çünkü bunlar iç içe çalışyor.
        {
            Data=data; //this ile aşağıdaki constrauctorı çağırmadığımız için burada da datayı verdik.
        }

        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
