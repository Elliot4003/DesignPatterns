using FactoryPattern.Interfaces;

namespace FactoryPattern.Products.Microsoft;

public class Xbox : IConsoleProduct
{
    public void CreationProcess()
    {
        Console.WriteLine("Xbox créée avec succès !");
    }
}
