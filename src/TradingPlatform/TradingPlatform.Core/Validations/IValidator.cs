using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Validations
{
    public interface IValidator<T>
    {
        Task ValidateAsync(T entity);
    }
}
