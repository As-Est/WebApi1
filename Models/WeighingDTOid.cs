﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WeighingDTOid
    {
        public int IDWeighing { get; set; }
        public string Item { get; set; }
        public int Weight { get; set; }
        public string Measure { get; set; }
        public string TareType { get; set; }
    }
}
