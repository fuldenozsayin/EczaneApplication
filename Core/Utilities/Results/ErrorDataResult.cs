using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //İster hem data hem mesaj ver
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        //İster sadece data ver
        public ErrorDataResult(T data) : base(data, false)
        {

        }

        //İstersen sadece mesaj ver
        public ErrorDataResult(string message) : base(default, false, message)//default dataya karşılık geliyor. Örneğin return tipi inttir ama bir şey döndürmek istemiyorsundur 
        {

        }

        //İstersen hiçbir şey verme
        public ErrorDataResult() : base(default, false)
        {

        }

    }
}
