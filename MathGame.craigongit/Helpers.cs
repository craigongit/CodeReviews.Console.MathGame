using Spectre.Console;

namespace MathGame;

internal static class Helpers
{
    private static int GenerateNumber()
    {
        return new Random().Next(1, 100);
    }
    
    internal static int[] GenerateOperands()
    {
        // Generated operands must results into a integer when division is performed 
        int firstOperand = GenerateNumber();
        int secondOperand = GenerateNumber();

        while (firstOperand % secondOperand != 0)
        {
            secondOperand = GenerateNumber();
        }

        return [firstOperand, secondOperand];
    }

    internal static string VerifyAnswer(int correctAnswer, int userAnswer)
    {
        if (userAnswer == correctAnswer)
        {
            return "Succeed!";
        }
        return "Failed!";
    }
    
    internal static void DisplayMessage(string message, string color = "yellow")
    {
        AnsiConsole.MarkupLine($"[{color}]{message}[/]");
    }
    

}