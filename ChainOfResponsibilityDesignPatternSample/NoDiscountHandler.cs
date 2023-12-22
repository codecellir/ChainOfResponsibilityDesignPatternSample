namespace ChainOfResponsibilityDesignPatternSample
{
    public class NoDiscountHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
        {
            return 0;
        }
    }
}
