using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Security
{
    public interface ISecurityService
    {
        Task<bool> ValidateAccessTokenAsync(string token);
        Task<string> GenerateAccessTokenAsync(string userId, IEnumerable<string> roles);
        Task<bool> HasPermissionAsync(string userId, string permission);
    }
}
