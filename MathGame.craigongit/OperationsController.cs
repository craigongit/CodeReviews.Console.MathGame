using MathGame.Models;
using static MathGame.Helpers;
using static MathGame.GameController;
using Spectre.Console;

namespace MathGame;

internal static class OperationsController
{
    // List of all games played,
    // all rounds considered
    internal static List<Game> GamesPlayed = [];
    
    internal static void DoOperation(string sign)
    {
        var operands = GenerateOperands();
        int correctAnswer = 0;

        switch (sign)
        {
            case "+":
                correctAnswer = operands[0] + operands[1];
                break;
            case "-":
                correctAnswer = operands[0] - operands[1];
                break;
            case "*":
                correctAnswer = operands[0] * operands[1];
                break;
            case "/":
                correctAnswer = operands[0] / operands[1];
                break;
        }
        
        DisplayMessage("Solve this operation:");
        
        var userAnswer = AnsiConsole.Ask<int>($"[teal]{operands[0]} {sign} {operands[1]} = [/]");

        var resultMessage = VerifyAnswer(userAnswer, correctAnswer);
        
        // Add 1 point if the answer is correct
        if (resultMessage == "Succeed!")
            Score++; // Score property from GameController class

        DisplayMessage(
            resultMessage,
            resultMessage == "Succeed!" ? "green" : "red");

        // Save game
        var currentGame = new Game($"{operands[0]} {sign} {operands[1]}", resultMessage);
        GamesPlayed.Add(currentGame);

        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }
    
    internal static void ShowHistory()
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);

        table.AddColumn("[yellow]Operation[/]");
        table.AddColumn("[yellow]User result[/]");
        
        foreach (var game in GamesPlayed)
        {
            // Result color in the table
            string resultColor = (game.ResultMessage == "Succeed!" ? "green" : "red");
            
            table.AddRow(
                $"[teal]{game.Expression}[/]",
                $"[{resultColor}]{game.ResultMessage}[/]");
        }
        
        AnsiConsole.Write(table);
        
        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }
}