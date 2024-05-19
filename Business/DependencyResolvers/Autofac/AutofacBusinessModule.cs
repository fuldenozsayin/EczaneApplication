using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.CCS;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<CourierManager>().As<ICourierService>();
            builder.RegisterType<EfCourierDal>().As<ICourierDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<OrderDetailManager>().As<IOrderDetailService>();
            builder.RegisterType<EfOrderDetailDal>().As<IOrderDetailDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<ReceiptDetailManager>().As<IReceiptDetailService>();
            builder.RegisterType<EfReceiptDetailDal>().As<IReceiptDetailDal>();

            builder.RegisterType<ReceiptManager>().As<IReceiptService>();
            builder.RegisterType<EfReceiptDal>().As<IReceiptDal>();

            builder.RegisterType<SellerManager>().As<ISellerService>();
            builder.RegisterType<EfSellerDal>().As<ISellerDal>();

            builder.RegisterType<StatusManager>().As<IStatusService>();
            builder.RegisterType<EfStatusDal>().As<IStatusDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }

}
