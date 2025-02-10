using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Configuration
{
    public record CachSettings
    {
        public required string RedisConnection { get; init; }
        public TimeSpan DefaultExpiration { get; init; } = TimeSpan.FromMinutes(5);
        public bool EnabledCompression { get; init; } = true;
    }
}
