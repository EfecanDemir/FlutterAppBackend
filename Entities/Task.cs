using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Task
    { 
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int RateId { get; set; }
        public bool TaskStatus { get; set; }

    }
}
