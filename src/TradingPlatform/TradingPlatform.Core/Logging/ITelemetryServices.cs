using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Logging
{
    public interface ITelemetryServices
    {
        void TrackEvent(string eventName, IDictionary<string, string> properties);
        void TrackException(Exception exception, IDictionary<string, string> properties);
        void TrackMetric(string name, double value);
        void TrackDependency(string name, double value);
    }
}
