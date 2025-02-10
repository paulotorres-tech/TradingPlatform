using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Enums;

namespace TradingPlatform.Core.Domain
{
    public record Order
    {
        public required string Id { get; init; }
        public required string AssetId { get; init; }
        public required OrderType Type { get; init; }
        public required OrderSide Side { get; init; }
        public required decimal Quantity { get; init; }
        public required decimal Price { get; init; }
        public OrderStatus Status { get; private set; } = OrderStatus.New;
        public required DateTime CreatedAt { get; init; }
        public decimal FilledQuantity { get; private set; }
        public DateTime? LastUpdate { get; private set; }

        public void UpdateStatus(OrderStatus newStatus, decimal? filledQty = null)
        {
            Status = newStatus;
            if (filledQty.HasValue)
            {
                FilledQuantity = filledQty.Value;
            }
            LastUpdate = DateTime.UtcNow;
        }
    }
}
