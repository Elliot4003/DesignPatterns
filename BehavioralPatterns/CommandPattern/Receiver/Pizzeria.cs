
namespace CommandPattern.Receivers;

public class Pizzeria
{
    private int _pizzaBoxStock;

    public Pizzeria()
    {
        _pizzaBoxStock = 3;
    }

    public void CookPizza(string pizzaType)
    {
        Console.WriteLine($"Préparation d'une pizza {pizzaType}...");
    }

    public void PackPizza()
    {
        Console.WriteLine($"Mise en boîte de la pizza...");

        _pizzaBoxStock -= 1;
    }

    public void DeliverPizza(string address)
    {
        Console.WriteLine($"Livraison à l'adresse : {address}...");
    }

    public void Success()
    {
        Console.WriteLine("Pizza livrée ! Yahoo !");
        Console.WriteLine();
    }

    public bool CanOrder()
    {
        return _pizzaBoxStock > 0;
    }
}

public record Order(string PizzaType, string Address);