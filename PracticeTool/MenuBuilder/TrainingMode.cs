namespace MenuBuilder;

internal class TrainingMode
{
    internal TrainingMode(string[] _trainingModeLines, int _row, int _line) => _ShowMenu(_trainingModeLines, _row, _line);

    private void _ShowMenu(string[] _trainingModeLines, int _row, int _line)
    {
        Console.Clear();

        Console.WriteLine($"Текущее количество вопросов: {PracticeTool.Data.QuestionsAmount}");
        
        var _trainingModeMenu = new Menu(_trainingModeLines, _row, _line);
        
        _trainingModeMenu.ModifyMenuCentered();
        _trainingModeMenu.CenterMenuToConsole();
        _trainingModeMenu.ResetCursorVisible();

        while (true)
        {
            switch (_trainingModeMenu.RunMenu())
            {
                case 0:
                    //todo: Доделать
                    throw new Exception();
                case 1:
                    PracticeTool.Data.QuestionsAmount += 5;
                
                    Console.Clear();
                
                    _trainingModeMenu.RunMenu();
                
                    break;
            }   
        }
    }
}