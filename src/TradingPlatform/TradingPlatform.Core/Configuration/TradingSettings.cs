using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Configuration
{
    public record TradingSettings
    {
        public required decimal MinOrderAmount{ get; init; }
        public required decimal MaxOrderAmount { get; init; }
        public required decimal TradingFeePercentage { get; init; }
        public required int MaxOpenOrders { get; init; }
        public required string[] SupportedQuoteCurrencies { get; init; }
    }
}
