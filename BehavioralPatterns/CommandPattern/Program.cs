using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPattern;

public class Program
{
    static void Main()
    {
        // Receveiver
        var pizzeria = new Pizzeria();
        var pizzeriaManager = new PizzeriaManager();

        pizzeriaManager.ExecuteCommand(new PizzaOrder(pizzeria, new Order("Hawaïenne", "54 Rue du gros kiffeur de pizzas")));

        pizzeriaManager.ExecuteCommand(new PizzaOrder(pizzeria, new Order("Royale", "2 Avenue du régime")));

        pizzeriaManager.ExecuteCommand(new PizzaOrder(pizzeria, new Order("Indienne", "65 Rue prise de masse")));

        pizzeriaManager.ExecuteCommand(new PizzaOrder(pizzeria, new Order("Raclette", "46 Rue patapizza")));
    }
}
