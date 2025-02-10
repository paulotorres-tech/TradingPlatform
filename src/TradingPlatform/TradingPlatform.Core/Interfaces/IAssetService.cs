using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Domain;

namespace TradingPlatform.Core.Interfaces
{
    public interface IAssetService
    {
        Task<Asset> GetAssetAsync(string assetId);
        Task<IEnumerable<Asset>> GetAllAssetsAsync();
        Task<decimal> GetCurrentPriceAsync(string assetId);
    }
}
