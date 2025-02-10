using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Domain;

namespace TradingPlatform.Core.Interfaces
{
    public interface ITradeService
    {
        Task<Order> PlaceOrderAsync(Order order);
        Task<Order> CancelOrderAsync(string orderId);
        Task<Order> GetOrderAsync(string orderId);
        Task<IEnumerable<Order>> GetOrdersAsync(string assetId);
    }
}
