﻿using System;
using System.Collections.Generic;

namespace DatabaseEF
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
