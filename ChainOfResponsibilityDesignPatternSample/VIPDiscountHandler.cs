namespace ChainOfResponsibilityDesignPatternSample
{
    public class VIPDiscountHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
        {
            if (customer.IsVIP)
            {
                return orderTotal * 0.8m;
            }
            return _nextHandler.CalculateDiscount(customer, orderTotal);
        }
    }
}
