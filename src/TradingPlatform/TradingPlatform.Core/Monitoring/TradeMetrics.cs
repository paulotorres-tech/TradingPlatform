using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Monitoring
{
    public record TradeMetrics
    {
        public int OrdersPerSecond { get; init; }
        public double AverageLatency { get; init; }
        public int ActiveConnections { get; init; }
        public int ErrorRate { get; init; }
    }
}
