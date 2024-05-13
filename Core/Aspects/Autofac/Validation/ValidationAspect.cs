using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    //ValidationAspect: Bir attribute
    //aspect demek metotun sonunda başında hata verdiğinde çalışacak yapı
    public class ValidationAspect : MethodInterception
    {
        //madem ben bir methodInterception ım benim ezmek istediğim bir metot var mı?
        //Sadece onBefore u ez
        private Type _validatorType;
        
        public ValidationAspect(Type validatorType)//bana diyor validator type ver
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil.");//eğer bir hata döndürüyorsan throw kullan return değil. Çünkü returnde sistem durmuyor throwda çalışmayı durdurur.
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); // IValidator validator  = new ProductValidator(); 
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//invocation, metot demek.Meotun parametlerine bak (arguments) entitytype a eşit olan parametreleri bul
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
