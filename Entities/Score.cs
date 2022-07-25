using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Score
    { 
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int UserTotalScore { get; set; }
        public double UserTotalRate { get; set; }

    }
}
