
using StrategyPattern.Interface;

namespace StrategyPattern.Contexts;

public class MessageSender
{
    private IStrategy _strategy;

    // Logique métier
    public void SendMessage()
    {
        _strategy.SendMessage();
    }

    // Modification de la stratégie utilisée
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }
}
