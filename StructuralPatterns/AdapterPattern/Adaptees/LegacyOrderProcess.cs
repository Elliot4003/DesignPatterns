
namespace AdapterPattern.Adaptees;

public class LegacyOrderProcess
{
    public void ProcessOrder(string product, string paymentType, float price)
    {
        Console.WriteLine("Commande :");
        Console.WriteLine($"Produit : {product}");
        Console.WriteLine($"Paiement : {paymentType}");
        Console.WriteLine($"Prix : {price}$");
        Console.WriteLine();
    }
}