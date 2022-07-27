using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IDutyDal : IEntityRepository<Duty>
    {
    }
}
