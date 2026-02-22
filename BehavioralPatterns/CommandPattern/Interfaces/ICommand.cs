
namespace CommandPattern.Interfaces;

public interface ICommand
{
    void Execute();
    bool CanExecute();
}
