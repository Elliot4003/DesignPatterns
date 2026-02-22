using StrategyPattern.Contexts;
using StrategyPattern.Strategies;

namespace StrategyPattern;

public class Program
{
    static void Main()
    {
        // Context
        var messageSender = new MessageSender();

        // Strategies
        var smsStrategy = new SmsStrategy();
        var mailStrategy = new MailStrategy();
        var pigeonStrategy = new PigeonStrategy();

        // Attribution d'une stratégie
        messageSender.SetStrategy(smsStrategy);
        messageSender.SendMessage();

        // Changement de stratégie
        messageSender.SetStrategy(mailStrategy);
        messageSender.SendMessage();

        // Changement de stratégie
        messageSender.SetStrategy(pigeonStrategy);
        messageSender.SendMessage();
    }
}