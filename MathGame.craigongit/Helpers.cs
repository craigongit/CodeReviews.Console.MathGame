using Spectre.Console;

namespace MathGame;

internal class Helpers
{
    private int GenerateNumber()
    {
        return new Random().Next(1, 100);
    }
    
    internal int[] GenerateOperands()
    {
        // Generated operands must results into a integer when division is performed 
        int firstOperand = GenerateNumber();
        int secondOperand = GenerateNumber();

        while (firstOperand % secondOperand != 0)
        {
            secondOperand = GenerateNumber();
        }

        return new int[]{firstOperand, secondOperand};
    }

    internal string VerifyAnswer(int correctAnswer, int userAnswer)
    {
        if (userAnswer == correctAnswer)
        {
            return "Succeed!";
        }
        return "Failed!";
    }
    
    internal void DisplayMessage(string message, string color = "yellow")
    {
        AnsiConsole.MarkupLine($"[{color}]{message}[/]");
    }
    

}