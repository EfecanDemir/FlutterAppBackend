using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CouponManager>().As<ICouponService>().SingleInstance();
            builder.RegisterType<EfCouponDal>().As<ICouponDal>().SingleInstance();

            builder.RegisterType<DutyManager>().As<IDutyService>().SingleInstance();
            builder.RegisterType<EfDutyDal>().As<IDutyDal>().SingleInstance();

            builder.RegisterType<GiftManager>().As<IGiftService>().SingleInstance();
            builder.RegisterType<EfGiftDal>().As<IGiftDal>().SingleInstance();

            builder.RegisterType<OrderManager>().As<IOrderService>().SingleInstance();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>().SingleInstance();

            builder.RegisterType<QuestionManager>().As<IQuestionService>().SingleInstance();
            builder.RegisterType<EfQuestionDal>().As<IQuestionDal>().SingleInstance();
        }
    }
}
