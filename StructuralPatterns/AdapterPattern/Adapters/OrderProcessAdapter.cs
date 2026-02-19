using AdapterPattern.Adaptees;
using AdapterPattern.Enums;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters;

public class OrderProcessAdapter : ITarget
{
    private readonly LegacyOrderProcess _legacyOrderProcess;
    
    public OrderProcessAdapter(LegacyOrderProcess legacyOrderProcess)
    {
        _legacyOrderProcess = legacyOrderProcess;
    }

    public void ProcessOrder(ProductsEnum product, PaymentTypesEnum paymentType, double price)
    {
        var convertedProduct = ConvertProduct(product);
        var convertedPaymentType = ConvertPaymentType(paymentType);
        var convertedPrice = ConvertPrice(price);

        _legacyOrderProcess.ProcessOrder(convertedProduct, convertedPaymentType, convertedPrice);
    }

    private static string ConvertProduct(ProductsEnum product)
    {
        return product.ToString();
    }

    private static string ConvertPaymentType(PaymentTypesEnum paymentType)
    {
        return paymentType.ToString();
    }

    private static float ConvertPrice(double price)
    {
        return (float)price;
    }
}
