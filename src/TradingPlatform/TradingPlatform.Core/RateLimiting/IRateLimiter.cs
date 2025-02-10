using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.RateLimiting
{
    public interface IRateLimiter
    {
        Task<bool> CheckLimiteAsync(string key, int limit, TimeSpan period);
        Task IncrementCounterAsync(string key);
        Task ResetCounterAsync(string key);
    }
}
