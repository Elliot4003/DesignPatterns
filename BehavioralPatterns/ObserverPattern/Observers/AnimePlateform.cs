using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;
using ObserverPattern.Enums;
using System.Reflection.Metadata;

namespace ObserverPattern.Observers;

public class AnimePlateform : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as MoviePublisher)?.Type == MovieTypesEnum.Anime)
        {
            Console.WriteLine($"Un film a été ajouté au catalogue de la plateforme d'anime");
            Console.WriteLine();
        }
    }
}
