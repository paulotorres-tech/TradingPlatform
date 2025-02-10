using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPlatform.Core.Exceptions
{
    public class TradingException : Exception
    {
        public string Code { get; }

        public TradingException(string message, string code) : base(message) { 
            Code = code;
        }
    }
}
