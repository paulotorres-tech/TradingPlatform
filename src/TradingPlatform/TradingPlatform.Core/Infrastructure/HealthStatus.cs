using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Infrastructure
{
    public record HealthStatus
    {
        public bool IsHealthy { get; init; }
        public Dictionary<string, string> Details { get; init; } = new();
        public DateTime CheckedAt { get; init; } = DateTime.UtcNow;
    }
}
