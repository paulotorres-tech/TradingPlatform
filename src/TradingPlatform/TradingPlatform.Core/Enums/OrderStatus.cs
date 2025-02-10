﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Enums
{
    public enum OrderStatus
    {
        New,
        PartiallyFilled,
        Filled,
        Cancelled,
        Rejected
    }
}
