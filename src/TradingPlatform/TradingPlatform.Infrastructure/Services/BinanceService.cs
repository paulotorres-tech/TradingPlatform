using Binance.Net.Clients;
using Binance.Net.Enums;
using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Domain.Enums;
using TradingPlatform.Domain.Interfaces;

namespace TradingPlatform.Infrastructure.Services
{
    public class BinanceService : IBinanceService
    {
        public Task<IEnumerable<Kline>> GetKlinesAsync(string symbol, KlineInterval interval, DateTime startTime, DateTime endTime, int limit = 500)
        {
            throw new NotImplementedException();
        }

        public Task<OrderOperationResult> PlaceOrderAsync(string symbol, Domain.Enums.OrderSide side, OrderType type, decimal quantity)
        {
            throw new NotImplementedException();
        }
    }
}
