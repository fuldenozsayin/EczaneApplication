using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //İster hem data hem mesaj ver
        public SuccessDataResult(T data, string message):base(data,true,message)
        {
            
        }

        //İster sadece data ver
        public SuccessDataResult(T data) : base(data,true)
        {

        }

        //İstersen sadece mesaj ver
        public SuccessDataResult(string message):base(default,true,message)//default dataya karşılık geliyor. Örneğin return tipi inttir ama bir şey döndürmek istemiyorsundur 
        {
            
        }

        //İstersen hiçbir şey verme
        public SuccessDataResult():base(default,true)
        {

        }

    }
}
