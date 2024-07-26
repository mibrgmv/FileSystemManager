namespace FileSystemManager.Source.CommandParser;

public interface ICommand
{
    ICommand SetNextCommand(ICommand command);
    void Execute(string command);
}
