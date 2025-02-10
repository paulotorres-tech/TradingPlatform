using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Configuration
{
    public record DatabaseSettings
    {
        public string CosmosDbConnection{ get; init; }
        public string MongoDbConnection { get; init; }
        public string DatabaseName { get; init; }
    }
}
