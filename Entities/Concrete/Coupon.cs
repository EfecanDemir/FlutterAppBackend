using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Coupon:IEntity
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public int UserId { get; set; }
        public bool CouponStatus { get; set; }
        public int CouponTotal { get; set; }
        public double? CouponRate { get; set; }
        public DateTime CouponEndDate { get; set; }
        
    }
}
