using FactoryPattern.Interfaces;
using FactoryPattern.Products.Microsoft;

namespace FactoryPattern.Factories;

public class MicrosoftFactory : IFactory
{
    public IConsoleProduct CreateConsole()
    {
        return new Xbox();
    }

    public IControllerProduct CreateController()
    {
        return new XboxController();
    }

    public IGameProduct CreateGame()
    {
        return new XboxGame();
    }
}