using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DutyManager:IDutyService
    {
        IDutyDal _dutyDal;
        public DutyManager(IDutyDal dutyDal)
        {
            _dutyDal = dutyDal;
        }

        public IDataResult<List<Duty>> GetAll()
        {
            return new SuccessDataResult<List<Duty>>(_dutyDal.GetAll());
        }

        public IDataResult<List<Duty>> GetByCouponId(int couponId)
        {
            var result = _dutyDal.GetAll(d => d.CouponId == couponId);
            return new SuccessDataResult<List<Duty>>(result);
        }
    }
}
