using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CouponManager : ICouponService
    {
        ICouponDal _couponDal;

        public CouponManager(ICouponDal couponDal)
        {
            _couponDal = couponDal;
        }

        public IResult Add(Coupon coupon)
        {
            _couponDal.Add(coupon);
            return new SuccessResult();
        }

        public IDataResult<List<Coupon>> GetAll()
        {
            return new SuccessDataResult<List<Coupon>>(_couponDal.GetAll());
        }

        public IDataResult<List<Coupon>> GetByUserId(int userId)
        {
            var result = _couponDal.GetAll(c => c.UserId == userId);
            return new SuccessDataResult<List<Coupon>>(result);
        }
    }
}
