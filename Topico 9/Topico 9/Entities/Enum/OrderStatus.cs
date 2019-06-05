using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_9.Entities.Enum
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
