using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //!!!!
        //Getter readOnly dir.ReadOnly ler constructor da set edilebilirler.
        //Sadece getter koymamızın nedeni; biz constractor dışında set etmek istemiyoruz.Bu yüzden aşağıdaki contstuctor yapısını kurduk.
        //Böylece sadece costructor yapsıyla kullanılsın istiyoruz.
        //Setter da koyabilirdik ama setter koyarsak programcı burada olayı kafasına göre kodlayabilridi. Biz setter koymayarak progrmacıyı sınırlıyoruz. Bunun amacı kodların okunurluğu standart olsun diye.
        //Bu da standartilize etmek oluyor.
        public Result(bool success, string message):this(success) //this kendi sınıfını (Result)ıkastediyor. //tek paremetreli olanı da çalıştır demek //yani diğer constructor ı da kapsıyor
        {
            Message = message;
            //Success = success; //success i set etme işini aşağıdakine veriyoruz 
        }

        public Result(bool success) //overloading
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message {  get; }
    }
}
