
using ChainOfResponsibilityDesignPatternSample;

var customer = new Customer { IsNew = true };

var vipHandler = new VIPDiscountHandler();

vipHandler
    .SetNextHandler(new RegularDiscountHandler())
    .SetNextHandler(new NewDiscountHandler())
    .SetNextHandler(new NoDiscountHandler());

var payableAmount = vipHandler.CalculateDiscount(customer, 10_000);

Console.WriteLine(payableAmount.ToString());
Console.ReadKey();
