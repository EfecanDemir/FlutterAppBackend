﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Gift:IEntity
    {
        public int Id { get; set; }
        public string GiftName { get; set; }
        public int GiftAmount { get; set; }
        public string GiftImage { get; set; }
        public string Description { get; set; }
    }
}
