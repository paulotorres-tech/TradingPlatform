using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Events
{
    public interface IEventPublisher
    {
        Task PublishPriceUpdateAsync(PriceUpdateEvent @event);
        Task PublishOrderStatusChangedAsync(OrderStatusChangedEvent @event);
    }
}
