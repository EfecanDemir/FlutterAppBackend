using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
    public interface ICouponService
    {
        IDataResult<List<Coupon>> GetAll();
        IResult Add(Coupon coupon);
        IDataResult<List<Coupon>> GetByUserId(int userId);

    }
}
