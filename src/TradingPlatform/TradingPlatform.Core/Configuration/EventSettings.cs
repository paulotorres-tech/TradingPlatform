using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Configuration
{
    public record EventSettings
    {
        public required string EventHubConnection { get; init; }
        public required string PriceUpdatesTopic { get; init; }
        public required string OrderUpdatesTopic { get; init; }
    }
}
