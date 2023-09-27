using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using MenuBuilder;
using PracticeTool;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        var startInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        
        Console.WriteLine(Translation.StartMenuDescription);
        
        var StartMenu = new Menu(Translation.StartMenuLines, 2, Translation.StartMenuLines.Length);
        
        StartMenu.ModifyMenuCentered();
        StartMenu.CenterMenuToConsole();
        StartMenu.ResetCursorVisible();

        switch (StartMenu.RunMenu())
        {
            case 0:
                new TrainingMode();
        }
    }
}