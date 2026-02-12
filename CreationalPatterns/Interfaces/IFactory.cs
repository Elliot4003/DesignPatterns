namespace FactoryPattern.Interfaces;

public interface IFactory
{
    IConsoleProduct CreateConsole();
    IControllerProduct CreateController();
    IGameProduct CreateGame();
}
