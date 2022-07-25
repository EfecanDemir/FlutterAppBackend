using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rate
    {
        public int Id { get; set; }
        public double? Positive { get; set; }
        public double? Negative { get; set; }
        public int QuestionId { get; set; }

    }
}
