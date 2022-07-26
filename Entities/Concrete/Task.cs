using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Task:IEntity
    { 
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int RateId { get; set; }
        public bool TaskStatus { get; set; }

    }
}
