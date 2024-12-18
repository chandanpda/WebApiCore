﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Dto
{
    public class JobLocationDto
    {
        public int Id { get; set; }
        public string UniqueGuid { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTimeOffset AddedOn { get; set; }
    }
}
