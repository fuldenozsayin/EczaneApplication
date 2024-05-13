using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        //virtual metotlar demek senin ezmen, bekleyen metotlar demek.
        //Biz bir aspect yazdığımızda o aspect nerede çalışsın istiyorsak gidip onun ilgili metotlarını eziyoruz.
        //Aspect demek MethodInterception'ı temel alan hangisini istiyorsan onu içeren operasyon 
        //virtual override edilebilir demek!!!!
        //invocation diyince metotlar gelsin aklına
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try //dene
            {
                invocation.Proceed();
            }
            catch (Exception e) //eğer hata varsa yakala (e dediğimiz şey try da gördüğümüz hata)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw; 
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
