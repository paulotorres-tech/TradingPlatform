using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.RateLimiting
{
    public record RateLimitInfo
    {
        public int RemainingRequests { get; init; }
        public DateTime Resetat { get; init; }
        public bool IsLimited { get; init; }
    }
}
