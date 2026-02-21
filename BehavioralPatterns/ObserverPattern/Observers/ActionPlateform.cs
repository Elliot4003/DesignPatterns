using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;
using ObserverPattern.Enums;

namespace ObserverPattern.Observers;

public class ActionPlateform : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as MoviePublisher)?.Type == MovieTypesEnum.Action)
        {
            Console.WriteLine($"Un film a été ajouté au catalogue de la plateforme de films d'action");
            Console.WriteLine();
        }
    }
}
