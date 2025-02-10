using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Logging
{
    public interface IPerformaceMonitor
    {
        IDisposable BeginOperation(string operationName);
        void RecordMetric(string metricName, double value);
        void TrackDependency(string dependencyName, Action operation);
    }
}
