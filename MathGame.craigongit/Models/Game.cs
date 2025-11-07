namespace MathGame.Models;

public class Game
{
    internal string Expression { get; set; }
    internal string ResultMessage { get; set; }

    internal Game(string expression, string resultMessage)
    {
        Expression = expression;
        ResultMessage = resultMessage;
    }
}