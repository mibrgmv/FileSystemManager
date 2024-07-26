using FileSystemManager.Source.CommandParser.ConnectionCommands;
using FileSystemManager.Source.CommandParser.FileCommands;
using FileSystemManager.Source.CommandParser.TreeCommands;
using FileSystemManager.Source.Models;

namespace FileSystemManager.Source.CommandParser;

public class Parser
{
    private ConnectCommand _connectCommand = new();
    private DisconnectCommand _disconnectCommand = new();
    private FileCommand _fileCommand = new();
    private TreeCommand _treeCommand = new();

    public Parser()
    {
        _connectCommand
            .SetNextCommand(_disconnectCommand)
            .SetNextCommand(_fileCommand)
            .SetNextCommand(_treeCommand);
    }

    public void Parse(ConsoleCommand command)
    {
        if (command == null)
            throw new ArgumentException("Console Command Cannot Be Null");
        _connectCommand.Execute(command.Value);
    }
}
