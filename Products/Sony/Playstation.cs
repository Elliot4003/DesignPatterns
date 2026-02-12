using FactoryPattern.Interfaces;

namespace FactoryPattern.Products.Sony;

public class Playstation : IConsoleProduct
{
    public void CreationProcess()
    {
        Console.WriteLine("Playstation créée avec succès !");
    }
}
