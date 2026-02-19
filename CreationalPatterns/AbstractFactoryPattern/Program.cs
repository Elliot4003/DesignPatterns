using FactoryPattern.Factories;
using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class Program
{
    static void ClientMain()
    {
        Console.WriteLine("Sony : 1");
        Console.WriteLine("Microsoft : 2");
        Console.WriteLine("Choisissez votre marque :");
        var input = Console.ReadLine();

        switch (input) 
        {
            case "1":
                ClientMethod(new SonyFactory());
                break;
            case "2":
                ClientMethod(new MicrosoftFactory());
                break;
            default:
                break;
        }
    }

    static void ClientMethod(IFactory factory)
    {
        var console = factory.CreateConsole();
        console.CreationProcess();

        var controller = factory.CreateController();
        controller.CreationProcess();

        var game = factory.CreateGame();
        game.CreationProcess();
    }

    static void Main(string[] args)
    {
        ClientMain();
    }
}
