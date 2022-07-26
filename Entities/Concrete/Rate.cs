using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Rate:IEntity
    {
        public int Id { get; set; }
        public double? Positive { get; set; }
        public double? Negative { get; set; }
        public int QuestionId { get; set; }

    }
}
