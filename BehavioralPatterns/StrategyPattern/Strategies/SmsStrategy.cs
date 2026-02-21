using StrategyPattern.Interface;

namespace StrategyPattern.Strategies;

public class SmsStrategy : IStrategy
{
    public void SendMessage()
    {
        Console.WriteLine("Message envoyé par SMS !");
    }
}
