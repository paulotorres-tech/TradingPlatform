using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.RateLimiting
{
    public record RateLimitConfig
    {
        public required int RequestsPerMinute { get; init; }
        public required int MaxBurstSize { get; init; }
        public Dictionary<string, int> EndpointLimits { get; init; } = new();
    }
}
