using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Events
{
    public record PriceUpdateEvent
    {
        public required string AssetId { get; init; }
        public required decimal NewPrice { get; init; }
        public required DateTime Timestamp { get; init; }
    }
}
