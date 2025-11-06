using Spectre.Console;
using static MathGame.Helpers;

namespace MathGame;

internal class Operations
{
    private readonly List<Game> _gameHistory = [];

    internal void Addition()
    {
        var operands = GenerateOperands();
        var correctAnswer = operands[0] + operands[1];
        
        DisplayMessage("Solve this operation:");
        
        var userAnswer = AnsiConsole.Ask<int>($"[teal]{operands[0]} + {operands[1]}[/]");

        var resultMessage = VerifyAnswer(userAnswer, correctAnswer);

        DisplayMessage(
            resultMessage,
            resultMessage == "Succeed!" ? "green" : "red");
        
        // Save game
        var game = new Game("Addition", operands[0], operands[1], "+", resultMessage);
        _gameHistory.Add(game);

        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }

    internal void Subtraction()
    {
        var operands = GenerateOperands();
        var correctAnswer = operands[0] - operands[1];
        
        DisplayMessage("Solve this operation:");
        
        var userAnswer = AnsiConsole.Ask<int>($"[teal]{operands[0]} - {operands[1]}[/]");

        var resultMessage = VerifyAnswer(userAnswer, correctAnswer);

        DisplayMessage(
            resultMessage,
            resultMessage == "Succeed!" ? "green" : "red");
        
        // Save game
        var game = new Game("Subtraction", operands[0], operands[1], "-", resultMessage);
        _gameHistory.Add(game);

        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }

    internal void Multiplication()
    {
        var operands = GenerateOperands();
        var correctAnswer = operands[0] * operands[1];
        
        DisplayMessage("Solve this operation:");
        
        var userAnswer = AnsiConsole.Ask<int>($"[teal]{operands[0]} * {operands[1]}[/]");

        var resultMessage = VerifyAnswer(userAnswer, correctAnswer);

        DisplayMessage(
            resultMessage,
            resultMessage == "Succeed!" ? "green" : "red");
        
        // Save game
        var game = new Game("Multiplication", operands[0], operands[1], "*", resultMessage);
        _gameHistory.Add(game);

        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }

    internal void Division()
    {
        var operands = GenerateOperands();
        var correctAnswer = operands[0] / operands[1];
        
        DisplayMessage("Solve this operation:");
        
        var userAnswer = AnsiConsole.Ask<int>($"[teal]{operands[0]} / {operands[1]}[/]");

        var resultMessage = VerifyAnswer(userAnswer, correctAnswer);

        DisplayMessage(
            resultMessage,
            resultMessage == "Succeed!" ? "green" : "red");
        
        // Save game
        var game = new Game("Division", operands[0], operands[1], "/", resultMessage);
        _gameHistory.Add(game);

        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }

    internal void Quit()
    {
        Environment.Exit(0);
    }

    internal void ShowHistory()
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);

        table.AddColumn("[yellow]Game[/]");
        table.AddColumn("[yellow]Operation[/]");
        table.AddColumn("[yellow]Result[/]");
        
        foreach (var game in _gameHistory)
        {
            // Result color in the table
            string resultColor = (game.ResultMessage == "Succeed!" ? "green" : "red");
            
            table.AddRow(
                $"[teal]{game.Operation}[/]", 
                $"[teal]{game.FirstOperand.ToString()} {game.Sign} {game.SecondOperand.ToString()}[/]", 
                $"[{resultColor}]{game.ResultMessage}[/]");
        }
        
        AnsiConsole.Write(table);
        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }
}