using FactoryPattern.Interfaces;

namespace FactoryPattern.Products.Microsoft;

public class XboxGame : IGameProduct
{
    public void CreationProcess()
    {
        Console.WriteLine("Jeu Xbox créé avec succès !");
    }
}

