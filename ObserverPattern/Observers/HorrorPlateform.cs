using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;
using ObserverPattern.Enums;

namespace ObserverPattern.Observers;

public class HorrorPlateform : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as MoviePublisher)?.Type == MovieTypesEnum.Horror)
        {
            Console.WriteLine($"Un film a été ajouté au catalogue de la plateforme de films d'horreur");
            Console.WriteLine();
        }
    }
}
