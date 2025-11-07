namespace MathGame.Models;

// This is the model of a question not a game round
// It will help displaying the history of the games
public class Game
{
    internal string Expression { get; set; } // e.g. 23 +12
    internal string ResultMessage { get; set; } // "Succeed!" or "Failed!"

    internal Game(string expression, string resultMessage)
    {
        Expression = expression;
        ResultMessage = resultMessage;
    }
}