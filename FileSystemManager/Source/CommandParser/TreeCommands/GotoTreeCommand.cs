using FileSystemManager.Source.Entities;

namespace FileSystemManager.Source.CommandParser.TreeCommands;

public class GotoTreeCommand : Command
{
    public override void Execute(string command)
    {
        if (command == null)
            throw new ArgumentException("Command To Execute Cannot Be Null");
        string[] split = command.Split(" ");
        if (split is ["tree", "goto", _])
        {
            FileSystem.GotoTree(split[2]);
        }
        else
        {
            base.Execute(command);
        }
    }
}