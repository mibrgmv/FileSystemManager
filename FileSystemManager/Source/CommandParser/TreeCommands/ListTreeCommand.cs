using System.Globalization;
using FileSystemManager.Source.Entities;

namespace FileSystemManager.Source.CommandParser.TreeCommands;

public class ListTreeCommand : Command
{
    public override void Execute(string command)
    {
        if (command == null)
            throw new ArgumentException("Command To Execute Cannot Be Null");
        string[] split = command.Split(" ");
        if (split is ["tree", "list", "-d", _])
        {
            FileSystem.ListTree(int.Parse(split[3], new NumberFormatInfo()));
        }
        else if (split is ["tree", "list"])
        {
            FileSystem.ListTree();
        }
        else
        {
            base.Execute(command);
        }
    }
}
