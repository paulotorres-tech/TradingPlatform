using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Enums;

namespace TradingPlatform.Core.Domain
{
    public record Asset
    {
        public required string Id { get; init; }
        public required string Symbol { get; init; }
        public string Name { get; init; }
        public AssetType Type { get; init; } = AssetType.Cryptocurrency;
        public decimal CurrentPrice { get; private set; }
        public required string BaseCurrency { get; init; }
        public string QuoteCurrency { get; init; }
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime LastUpdated { get; private set; }

        public void UpdatePrice(decimal newPrice)
        {
            CurrentPrice = newPrice;
            LastUpdated = DateTime.UtcNow;
        }
    }
}
