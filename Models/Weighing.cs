﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Weighing
    {
        public int IDWeighing { get; set; }
        public string Item { get; set; }
        public int Weight { get; set; }
        public int? idMeasure { get; set; }
        public Measure Measure { get; set; }
        public string TareType { get; set; }
    }
}
