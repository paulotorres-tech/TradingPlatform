using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Exceptions
{
    public class OrderNotFoundException : TradingException
    {
        public OrderNotFoundException(string orderId)
            : base($"Order {orderId} not found.", "ORDER_NOT_FOUNT") { }
    }
}
