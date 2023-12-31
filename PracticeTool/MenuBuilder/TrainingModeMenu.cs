namespace MenuBuilder;

internal class TrainingModeMenu
{
    internal TrainingModeMenu(string[] _trainingModeLines, int _row, int _line) =>
        _ShowMenu(_trainingModeLines, _row, _line);

    private void _ShowMenu(string[] _trainingModeLines, int _row, int _line)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Текущее количество вопросов: {PracticeTool.Data.QuestionsAmount}");

            var _trainingModeMenu = new Menu(_trainingModeLines, _row, _line);

            _trainingModeMenu.ModifyMenuCentered();
            _trainingModeMenu.CenterMenuToConsole();
            _trainingModeMenu.ResetCursorVisible();

            switch (_trainingModeMenu.RunMenu())
            {
                case 0:
                    new MainGame();
                    break;
                case 1:
                    PracticeTool.Data.QuestionsAmount += 5;
                    continue;
                case 2:
                    if (PracticeTool.Data.QuestionsAmount <= 5)
                    {
                        continue;
                    }
                    PracticeTool.Data.QuestionsAmount -= 5;
                    continue;
                case 3:
                    break;
                default:
                    continue;
            }
            break;
        }
        
        Console.Clear();
        Program.Main();
    }
}