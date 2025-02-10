using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Data
{
    public abstract class BaseEntity
    {
        public required int Id { get; init; }
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; }

        protected void SetUpdatedAt() => UpdatedAt = DateTime.UtcNow;
    }
}
