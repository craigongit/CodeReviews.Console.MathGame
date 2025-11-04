namespace MathGame;

internal class Game
{
    internal string Operation { get; set; }
    internal int FirstOperand { get; set; }
    internal int SecondOperand { get; set; }
    internal string Sign { get; set; }
    internal string ResultMessage { get; set; }

    internal Game(string operation, int firstOperand, int secondOperand, string sign, string resultMessage)
    {
        Operation = operation;
        FirstOperand = firstOperand;
        SecondOperand = secondOperand;
        Sign = sign;
        ResultMessage = resultMessage;
    }
}