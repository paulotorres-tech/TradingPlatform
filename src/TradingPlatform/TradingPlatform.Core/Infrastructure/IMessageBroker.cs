using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Infrastructure
{
    public interface IMessageBroker
    {
        Task PublishAsync<T>(string topic, T message);
        Task SubscribeAsync<T>(string topic, Func<T, Task> handler);
        Task UnsubscribeAsync<T>(string topic);
    }
}
