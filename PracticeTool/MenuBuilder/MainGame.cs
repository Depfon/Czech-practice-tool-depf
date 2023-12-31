using PracticeTool;

namespace MenuBuilder;

public class MainGame
{
    private int _mistakesAmount = 0;

    public MainGame()
    {
        var _mainGameMenu = new Menu(Translation.MainGameLines, Config.MainMenuRow, Translation.MainGameLines.Length);
        var _random = new Random();
        
        Console.Clear();
        
        _mainGameMenu.ModifyMenuCentered();
        _mainGameMenu.CenterMenuToConsole();
        _mainGameMenu.ResetCursorVisible();

        int _lesson = _mainGameMenu.RunMenu();

        int _randomNumber = 0;
        string _answer;
        
        for (int i = 0; i <= PracticeTool.Data.QuestionsAmount; i++)
        {
            Console.Clear();
            
            _randomNumber = _random.Next(Translation.LessonArray.GetLength(1));
            
            Console.WriteLine("\t" + Translation.LessonArray[_lesson, _randomNumber, 1]);
            Console.Write("\t");
            _answer = Console.ReadLine();

            Console.Clear();
            
            if (_answer.ToLower() != Translation.LessonArray[_lesson, _randomNumber, 0].ToLower())
            {
                _mistakesAmount++;
                
                Console.WriteLine($"\tВапфщета  {Translation.LessonArray[_lesson, _randomNumber, 1]}\n\t это {Translation.LessonArray[_lesson, _randomNumber, 0]}");
                Console.WriteLine($"\tА вы написали {_answer}");
            
                Console.WriteLine("\n\t нажмите любую кнопку для продолжения");
                
                Console.ReadKey();
            }
            
        }
        
        Console.Clear();
        Console.WriteLine($"\tУрааааа, тренировка завершена, вы совершили {_mistakesAmount} ошибок.");
        Console.WriteLine("Если что, больше функционала не будет. Я заебался эту хуйню делать. 10 часов потратил блчть.\n Если гитхаб откроете, то заметите, что под конец говнокодил люто. Не бейте, пожалуйста.\n\n Если хотите заново потренироваться, то перезапустите программу.");
    }

    private void _StartGame()
    {
        
    }
}