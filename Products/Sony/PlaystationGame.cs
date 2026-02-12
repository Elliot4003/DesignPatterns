using FactoryPattern.Interfaces;

namespace FactoryPattern.Products.Sony;

public class PlaystationGame : IGameProduct
{
    public void CreationProcess()
    {
        Console.WriteLine("Jeu Playstation créé avec succès !");
    }
}
