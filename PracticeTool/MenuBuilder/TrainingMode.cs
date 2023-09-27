namespace MenuBuilder;

internal class TrainingMode
{
    internal TrainingMode (string[] _trainingModeLines, int _row, int _line)
    {
        Console.Clear();

        var _trainingModeMenu = new Menu(_trainingModeLines, _row, _line);
        
        _trainingModeMenu.ModifyMenuCentered();
        _trainingModeMenu.CenterMenuToConsole();
        _trainingModeMenu.ResetCursorVisible();
        
    }
    
    
}