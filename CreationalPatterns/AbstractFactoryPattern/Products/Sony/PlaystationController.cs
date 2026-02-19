using FactoryPattern.Interfaces;

namespace FactoryPattern.Products.Sony;

public class PlaystationController : IControllerProduct
{
    public void CreationProcess()
    {
        Console.WriteLine("Manette Playstation créée avec succès !");
    }
}
