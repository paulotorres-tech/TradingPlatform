using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Events
{
    public interface IEventHandler<T> where T : class
    {
        Task HandleAsync(T @event);
    }
}
