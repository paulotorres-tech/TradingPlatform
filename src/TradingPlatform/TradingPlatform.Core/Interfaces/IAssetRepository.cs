using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Domain;

namespace TradingPlatform.Core.Interfaces
{
    public interface IAssetRepository
    {
        Task<Asset> GetByIdAsync(string assetId);
        Task<IEnumerable<Asset>> GetAllAsync();
        Task<Asset> AddAsync(Asset asset);
        Task<Asset> UpdateAsync(Asset asset);
    }
}
