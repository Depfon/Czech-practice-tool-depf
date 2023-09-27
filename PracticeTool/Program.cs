using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using MenuBuilder;

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
        
        Console.WriteLine("Выбирайте между элементами меню при помощи стрелок \u2195");
        
        string[] MenuLines = { "- Режим тренировки", "- Бесконечный режим"};
        
        Menu BaseMenu = new Menu(MenuLines, 2, MenuLines.Length);
        
        BaseMenu.ModifyMenuCentered();
        BaseMenu.CenterMenuToConsole();
        BaseMenu.ResetCursorVisible();

        switch (BaseMenu.RunMenu())
        {
            case 0:
                new TrainingMode();
        }
    }
}