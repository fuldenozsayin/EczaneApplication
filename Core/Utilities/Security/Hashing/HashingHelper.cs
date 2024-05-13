using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper //Araç olduğu için çıplak kalabilir.
    {
        /*out anahtar kelimesi, bir C# metodu tarafından birden fazla değer döndürmek için kullanılır. 
         * Bir metodun out parametresine sahip olduğu bir değişken, metodun çağrıldığı yerde değeri atanmış olmasa da, metodun içinde bir değer atanabilir ve 
         * bu değer çağıran kod bloğuna döndürülür.*/
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)//ona verdiğimiz passwordun bir hashini oluşturacak.
        {
            //bu metot verilen passwrod değerine göre hash ve saltını oluşturmaya yrıyor.
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;//Her kullanıcı için başka bir key oluşturur.
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //PASSWORD un byte değerini almak için encoding.. yaptık
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)//verify(doğrula)
        {
            //password kullanıcının girdiği parola
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash=hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for(int i=0; i<computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
