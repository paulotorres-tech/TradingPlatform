using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Caching
{
    public static class CacheKeys
    {
        public static string AssetPrice(string assetId) => $"AssetPrice:{assetId}";
        public static string AssetDetails(string assetId) => $"Asset:{assetId}";
        public static string OrderDetails(string orderId) => $"Order:{orderId}";
        public static string UserOrders(string userId) => $"UserOrders:{userId}";
    }
}
