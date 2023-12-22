using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternSample
{
    public class NewDiscountHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
        {
            if (customer.IsNew)
            {
                return orderTotal * 0.95m;
            }
            return _nextHandler.CalculateDiscount(customer, orderTotal);
        }
    }
}
