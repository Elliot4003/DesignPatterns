using ObserverPattern.Enums;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Subjects;

public class MoviePublisher : ISubject
{
    private event Action<ISubject>? SubjectNotification; // Délégué permettant d'impacter tous les observers abonnés
    public MovieTypesEnum Type { get; private set; } = MovieTypesEnum.Undefined;
    private readonly List<IObserver> _observers = [];

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
        SubjectNotification += observer.Update; // Abonner l'observer
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        SubjectNotification -= observer.Update; // Désabonner l'observer
    }

    private void Notify()
    {
        SubjectNotification?.Invoke(this); // Appel des méthodes update des observers abonnés
    }

    // Simule la logique métier
    public void PublishMovie(MovieTypesEnum type)
    {
        Type = type;

        Notify();
    }
}
