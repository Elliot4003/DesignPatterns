using FactoryPattern.Interfaces;

namespace FactoryPattern.Products.Microsoft;

public class XboxController : IControllerProduct
{
    public void CreationProcess()
    {
        Console.WriteLine("Manette Xbox créée avec succès !");
    }
}
