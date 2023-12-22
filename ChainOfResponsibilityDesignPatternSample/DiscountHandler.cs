using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternSample
{
    public abstract class DiscountHandler
    {
        protected DiscountHandler _nextHandler;
        public DiscountHandler SetNextHandler(DiscountHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }

        public abstract decimal CalculateDiscount(Customer customer, decimal orderTotal);
    }
}
