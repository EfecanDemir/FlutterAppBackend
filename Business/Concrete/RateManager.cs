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
    public class RateManager:IRateService
    {
        IRateDal _rateDal;

        public RateManager(IRateDal rateDal)
        {
            _rateDal = rateDal;
        }

        public IResult Add(Rate rate)
        {
            _rateDal.Add(rate);
            return new SuccessResult();
        }

        public IDataResult<List<Rate>> GetAll()
        {
            return new SuccessDataResult<List<Rate>>(_rateDal.GetAll());
        }
    }
}
