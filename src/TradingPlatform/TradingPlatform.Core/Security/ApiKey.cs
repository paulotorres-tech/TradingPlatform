using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Security
{
    public record ApiKey
    {
        public required string Key { get; init; }
        public required string UserId { get; init; }
        public required DateTime CreatedAt { get; init; }
        public required DateTime? ExpiredAt { get; init; }
        public bool IsActived { get; private set; } = true;

        public void Revoke() => IsActived = false;
    }
}
