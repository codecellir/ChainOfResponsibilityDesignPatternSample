using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternSample
{
    public class RegularDiscountHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
        {
            if (customer.IsRegular)
            {
                return orderTotal * 0.9m;
            }
            return _nextHandler.CalculateDiscount(customer, orderTotal);
        }
    }
}
