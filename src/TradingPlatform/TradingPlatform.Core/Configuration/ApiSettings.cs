using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Configuration
{
    public record ApiSettings
    {
        public required string[] AllowdOrigins { get; init; }
        public required int RateLimitPerMinute { get; init; }
        public required string ApiVersion { get; init; }
    }
}
