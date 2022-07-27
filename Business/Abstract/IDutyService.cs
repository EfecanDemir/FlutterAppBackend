﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDutyService
    {
        IDataResult<List<Duty>> GetAll();
        IDataResult<List<Duty>> GetByCouponId(int couponId);
    }
}
