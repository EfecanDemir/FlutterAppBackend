using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Duty : IEntity
    { 
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int QuestionId { get; set; }
        public bool TaskStatus { get; set; }

    }
}
