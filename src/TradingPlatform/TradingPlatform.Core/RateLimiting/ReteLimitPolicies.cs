using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.RateLimiting
{
    public static class ReteLimitPolicies
    {
        public static readonly TimeSpan DefaultPeriod = TimeSpan.FromMinutes(1);
        public const int PublicApiLimit = 100;
        public const int AuthenticatedApiLimit = 1000;
        public const int TradingApiLimit = 500;
    }
}
