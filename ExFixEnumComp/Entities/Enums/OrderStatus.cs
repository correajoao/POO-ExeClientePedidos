﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixEnumComp.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
