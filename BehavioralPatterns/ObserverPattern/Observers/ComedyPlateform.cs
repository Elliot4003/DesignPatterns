using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;
using ObserverPattern.Enums;

namespace ObserverPattern.Observers;

public class ComedyPlateform : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as MoviePublisher)?.Type == MovieTypesEnum.Comedy)
        {
            Console.WriteLine($"Un film a été ajouté au catalogue de la plateforme de comédies");
            Console.WriteLine();
        }
    }
}
