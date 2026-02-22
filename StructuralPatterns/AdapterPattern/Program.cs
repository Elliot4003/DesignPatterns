using AdapterPattern.Enums;
using AdapterPattern.Adaptees;
using AdapterPattern.Adapters;
using AdapterPattern.Clients;

namespace AdapterPattern;

public class Program
{
    static void Main()
    {
        var legacyOrderProcess = new LegacyOrderProcess();
        var orderProcessor = new OrderProcessAdapter(legacyOrderProcess);
        var apiOrderProcess = new ApiOrderProcess(orderProcessor);

        apiOrderProcess.ProcessOrder(ProductsEnum.PlasticDuck, PaymentTypesEnum.Cash, 3.99);

        apiOrderProcess.ProcessOrder(ProductsEnum.RealDinosaur, PaymentTypesEnum.CreditCard, 2_500_000);

        apiOrderProcess.ProcessOrder(ProductsEnum.LightSaber, PaymentTypesEnum.Check, 999.90);

        apiOrderProcess.ProcessOrder(ProductsEnum.GiantBouncingBall, PaymentTypesEnum.ExternalPlateform, 19.99);
    }
}
