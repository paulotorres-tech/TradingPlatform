using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Monitoring
{
    public record ResourceMetrics
    {
        public double CpuUsage { get; init; }
        public double MemoryUsage { get; init; }
        public double NetworkIO { get; init; }
        public double DatabaseConnections { get; init; }
        public Dictionary<string, double> CustomMetrics { get; init; } = new();
    }
}
