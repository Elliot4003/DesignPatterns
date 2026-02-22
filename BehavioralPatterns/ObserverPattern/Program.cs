using ObserverPattern.Enums;
using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern;

public class Program
{
    static void Main()
    {
        // Subject
        var moviePublisher = new MoviePublisher();

        // Observers
        var actionPlateformObserver = new ActionPlateform();
        var horrorPlateformobserver = new HorrorPlateform();
        var comedyPlateformobserver = new ComedyPlateform();
        var animePlateformobserver = new AnimePlateform();

        moviePublisher.Attach(actionPlateformObserver);
        moviePublisher.Attach(horrorPlateformobserver);
        moviePublisher.Attach(comedyPlateformobserver);
        moviePublisher.Attach(animePlateformobserver);

        moviePublisher.PublishMovie(MovieTypesEnum.Action);
        moviePublisher.PublishMovie(MovieTypesEnum.Horror);
        moviePublisher.PublishMovie(MovieTypesEnum.Comedy);
        moviePublisher.PublishMovie(MovieTypesEnum.Anime);

        moviePublisher.Detach(actionPlateformObserver);

        moviePublisher.PublishMovie(MovieTypesEnum.Action);
        moviePublisher.PublishMovie(MovieTypesEnum.Horror);
    }
}
