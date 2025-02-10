using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Security
{
    public static class Permissions
    {
        public const string Trade = "trade";
        public const string ViewOrders = "view:orders";
        public const string ManageApiKeys = "manage:apiKeys";
        public const string Admin = "admin";
    }
}
