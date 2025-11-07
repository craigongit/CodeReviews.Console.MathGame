using static MathGame.OperationsController;

namespace MathGame;

public static class GameController
{

    internal static int Score = 0;
    
    internal static void PlayGame()
    {
        Random random = new Random();
        var operations = Enum.GetValues<Enums.Operations>();
        
        for (int i = 5; i > 0; i--)
        {
            int index = random.Next(operations.Length);
            var chosenOperation = operations[index];

            switch (chosenOperation)
            {
                case Enums.Operations.Addition:
                    DoOperation("+");
                    break;
                case Enums.Operations.Subtraction:
                    DoOperation("-");
                    break;
                case Enums.Operations.Multiplication:
                    DoOperation("*");
                    break;
                case Enums.Operations.Division:
                    DoOperation("/");
                    break;
            }
            
            Console.Clear();
        }

        Console.ReadKey();
    }

    internal static void ShowHistory()
    {
        throw new NotImplementedException();
    }
}