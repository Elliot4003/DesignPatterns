
using AdapterPattern.Enums;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Clients;

public class ApiOrderProcess
{
    private readonly ITarget _orderProcessor;

    public ApiOrderProcess(ITarget orderProcessor)
    {
        _orderProcessor = orderProcessor;
    }

    public void ProcessOrder(ProductsEnum product, PaymentTypesEnum paymentType, double price)
    {
        _orderProcessor.ProcessOrder(product, paymentType, price);
    }
}
