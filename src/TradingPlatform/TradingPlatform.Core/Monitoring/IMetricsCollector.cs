using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TradingPlatform.Core.Enums;

namespace TradingPlatform.Core.Monitoring
{
    public interface IMetricsCollector
    {
        void RecordTradeExecution(string assetId, decimal price, decimal quantity);
        void RecordOrderCreation(string assetId, OrderType orderType);
        void RecordLatency(string operation, TimeSpan duration);
        void RecordError(string errorType, string details);
    }
}
