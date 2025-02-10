using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingPlatform.Core.Domain;
using TradingPlatform.Core.Enums;
using TradingPlatform.Core.Exceptions;

namespace TradingPlatform.Core.Validations
{
    public class OrderValidator : IValidator<Order>
    {
        public Task ValidateAsync(Order order)
        {
            if (order.Quantity <= 0)
                throw new ValidationException("Order quantity must be greater than zero.");

            if (order.Price <= 0 && order.Type == OrderType.Limit)
                throw new ValidationException("Limit order price must be greater than zero.");

            return Task.CompletedTask;
        }
    }
}
