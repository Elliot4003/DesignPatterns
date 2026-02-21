using StrategyPattern.Interface;

namespace StrategyPattern.Strategies;

public class MailStrategy : IStrategy
{
    public void SendMessage()
    {
        Console.WriteLine("Message envoyé par mail !");
    }
}
