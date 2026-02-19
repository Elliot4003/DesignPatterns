using AdapterPattern.Enums;

namespace AdapterPattern.Interfaces;

public interface ITarget
{
    void ProcessOrder(ProductsEnum product, PaymentTypesEnum paymentType, double price);
}