using FileSystemManager.Source.CommandParser;
using FileSystemManager.Source.Entities;
using FileSystemManager.Source.Models;

namespace FileSystemManager.Source;

public static class Program
{
    public static void Run()
    {
        var parser = new Parser();
        FileSystem.SetEmojis("\ud83d\udc95", "💖");
        FileSystem.SetLogger(new ConsoleLogger());
        while (true)
        {
            string? command = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(command)) break;
            parser.Parse(new ConsoleCommand(command));
        }
    }
}