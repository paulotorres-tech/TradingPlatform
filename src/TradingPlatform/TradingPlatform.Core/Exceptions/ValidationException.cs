using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Exceptions
{
    public class ValidationException : TradingException
    {
        public ValidationException(string message) : base(message, "VALIDATION_ERROR") { }
    }
}
