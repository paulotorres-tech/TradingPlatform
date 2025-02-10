using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Exceptions
{
    public class AssetNotFoundException : TradingException
    {
        public AssetNotFoundException(string assetId)
            : base($"Asset {assetId} not found.", "ASSET_NOT_FOUND") { }
    }
}
