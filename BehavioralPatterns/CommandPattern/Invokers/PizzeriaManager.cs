using CommandPattern.Interfaces;

namespace CommandPattern.Invokers;

public class PizzeriaManager
{
    // L'invoker sert de manager afin de centraliser l'exécution des commandes
    // et d'ajouter des contrôles ainsi qu'une potentielle logique métier
    public void ExecuteCommand(ICommand command)
    {
        if(command.CanExecute())
        {
            command.Execute();
        }
        else
        {
            Console.WriteLine("Plus de boîte à pizza, mamma mia !");
        }
    }
}