using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using MenuBuilder;
using PracticeTool;

public class Program
{
    public static void Main()
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        var startInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        
        Console.WriteLine(Translation.StartMenuDescription);
        
        var StartMenu = new Menu(Translation.StartMenuLines, Config.StartMenuRow, Translation.StartMenuLines.Length);
        
        StartMenu.ModifyMenuCentered();
        StartMenu.CenterMenuToConsole();
        StartMenu.ResetCursorVisible();

        switch (StartMenu.RunMenu())
        {
            case 0:
                new TrainingModeMenu(Translation.TrainingModeLines, Config.TrainingModeRow, Translation.TrainingModeLines.Length);
                break;
            case 1:
                Data.QuestionsAmount = Int32.MaxValue;
                new MainGame();
                break;
            default:
                break;
        }
    }
}