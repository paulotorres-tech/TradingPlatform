using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Infrastructure
{
    public interface IBackgroundTaskQueue
    {
        Task QueueTaskAsync(Func<CancellationToken, Task> task);
        Task<Func<CancellationToken, Task>> DequeueTaskAsync(CancellationToken cancellationToken);
    }
}
