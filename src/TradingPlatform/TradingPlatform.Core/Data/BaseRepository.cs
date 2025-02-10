using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Logging;

namespace TradingPlatform.Core.Data
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly ILoggerService<BaseRepository<T>> _logger;
        protected readonly ITelemetryServices _telemetry;

        protected BaseRepository(ILoggerService<BaseRepository<T>> logger, 
            ITelemetryServices telemetry)
        {
            _logger = logger;
            _telemetry = telemetry;
        }

        public abstract Task<T> GetByIdAsync(string id);
        public abstract Task<IEnumerable<T>> GetAllAsync();
        public abstract Task<T> AddAsync(T entity);
        public abstract Task UpdateAsync(T entity);
        public abstract Task DeleteAsync(string id);
    }
}
