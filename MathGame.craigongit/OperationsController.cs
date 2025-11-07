using static MathGame.Helpers;
using static MathGame.GameController;
using Spectre.Console;

namespace MathGame;

internal static class OperationsController
{
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

        DisplayMessage("Press Any Key to Continue!");
        Console.ReadKey();
    }
}