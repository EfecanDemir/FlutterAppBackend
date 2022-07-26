using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Question:IEntity
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public int Point { get; set; }
        public DateTime Enddate { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
