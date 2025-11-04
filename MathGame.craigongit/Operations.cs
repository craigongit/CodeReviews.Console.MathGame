using Spectre.Console;

namespace MathGame;

public class Operations
{
    private List<Game> _gameHistory = [];
    private readonly Helpers _helpers = new Helpers();

    public void Addition()
    {
        var operands = _helpers.GenerateOperands();
        var correctAnswer = operands[0] + operands[1];
        
        _helpers.DisplayMessage("Solve this operation:");
        
        var userAnswer = AnsiConsole.Ask<int>($"[white]{operands[0]} + {operands[1]}[/]");
        
        _helpers.VerifyAnswer(userAnswer, correctAnswer);
        
        // Save game
        var game = new Game("Addition", operands[0], operands[1]);
        _gameHistory.Add(game);
    }
}