using static MathGame.Helpers;
using static MathGame.OperationsController;

namespace MathGame;

public static class GameController
{
    // score variable persisting during the whole program lifecycle
    internal static int Score = 0;
    
    // Triggers a new game round of 5 questions 
    // Each of the 5 operation types is chosen randomly
    // from the OperationTypes enum
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
        
        // Display score after a game round
        DisplayMessage("-------------------------");
        DisplayMessage($"You finished with a score of: {Score} / {GamesPlayed.Count}");
        DisplayMessage("-------------------------");
        
        Console.WriteLine("Press Any Key to Continue!");

        Console.ReadKey();
    }
}