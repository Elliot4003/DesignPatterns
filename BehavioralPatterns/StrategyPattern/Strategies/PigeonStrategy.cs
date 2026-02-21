using StrategyPattern.Interface;

namespace StrategyPattern.Strategies;

public class PigeonStrategy : IStrategy
{
    public void SendMessage()
    {
        Console.WriteLine("Message envoyé par pigeon voyageur !");
    }
}
