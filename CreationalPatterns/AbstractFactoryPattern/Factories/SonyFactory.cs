using FactoryPattern.Interfaces;
using FactoryPattern.Products.Sony;

namespace FactoryPattern.Factories;

public class SonyFactory : IFactory
{
    public IConsoleProduct CreateConsole()
    {
        return new Playstation();
    }

    public IControllerProduct CreateController()
    {
        return new PlaystationController();
    }

    public IGameProduct CreateGame()
    {
        return new PlaystationGame();
    }
}

