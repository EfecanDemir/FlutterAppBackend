using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int GiftId { get; set; }
        public int UserId { get; set; }
    }
}
