using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Domain;

namespace TradingPlatform.Core.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(string orderId);
        Task<IEnumerable<Order>> GetByAssetIdAsync(string assetId);
        Task<IEnumerable<Order>> GetAllAsync();
        Task<Order> AddAsync(Order order);
        Task<Order> UpdateAsync(Order order);
    }
}
