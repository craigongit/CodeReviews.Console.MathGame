using Spectre.Console;

namespace MathGame;

public class Operations
{
    private List<Game> _gameHistory = [];
    private Helpers _helpers = new Helpers();

    public void Addition()
    {
        var operands = _helpers.GenerateOperands();
        var correctAnswer = operands[0] + operands[1];
        
        _helpers.DisplayMessage("Solve this operation:");
        
        var userAnswer = AnsiConsole.Ask<int>($"[teal]{operands[0]} + {operands[1]}[/]");

        var resultMessage = _helpers.VerifyAnswer(userAnswer, correctAnswer);

        _helpers.DisplayMessage(
            resultMessage,
            resultMessage == "Succeed!" ? "green" : "red");
        
        // Save game
        var game = new Game("Addition", operands[0], operands[1], "+", resultMessage);
        _gameHistory.Add(game);

        _helpers.DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }

    public void ShowHistory()
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);

        table.AddColumn("[yellow]Game[/]");
        table.AddColumn("[yellow]Operation[/]");
        table.AddColumn("[yellow]Result[/]");
        
        foreach (var game in _gameHistory)
        {
            // Color when displaying result in the table
            string resultColor = (game.ResultMessage == "Succeed!" ? "green" : "red");
            
            table.AddRow(
                $"[teal]{game.Operation}[/]", 
                $"[teal]{game.FirstOperand.ToString()} {game.Sign} {game.SecondOperand.ToString()}[/]", 
                $"[{resultColor}]{game.ResultMessage}[/]");
        }
        
        AnsiConsole.Write(table);
        _helpers.DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }
}