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
    public class GiftManager : IGiftService
    {
        IGiftDal _giftDal;

        public GiftManager(IGiftDal giftDal)
        {
            _giftDal = giftDal;
        }

        public IDataResult<List<Gift>> GetAll()
        {
            return new SuccessDataResult<List<Gift>>(_giftDal.GetAll());
        }
    }
}
