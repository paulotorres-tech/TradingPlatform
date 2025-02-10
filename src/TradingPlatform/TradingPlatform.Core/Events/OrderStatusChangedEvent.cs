using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Enums;

namespace TradingPlatform.Core.Events
{
    public record OrderStatusChangedEvent
    {
        public required string OrderId { get; init; }
        public required OrderStatus NewStatus { get; init; }
        public decimal? FilledQuantity { get; init; }
        public required DateTime Timestamp { get; init; }
    }
}
