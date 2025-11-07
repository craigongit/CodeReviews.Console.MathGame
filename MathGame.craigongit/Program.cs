using MathGame;
using Spectre.Console;
using static MathGame.GameController;
using static MathGame.OperationsController;

// TO-DO
// Implement score system
// A game has 5 random operations
// 

while (true)
{
    Console.Clear();
    
    var userChoice = AnsiConsole.Prompt(
        new SelectionPrompt<Enums.UserOptions>()
            .Title("Select an option!")
            .AddChoices(Enum.GetValues<Enums.UserOptions>()));

    switch (userChoice)
    {
        case Enums.UserOptions.PlayGame:
            PlayGame();
            break;
        case Enums.UserOptions.History:
            ShowHistory();
            break;
        case Enums.UserOptions.Quit:
            Environment.Exit(0);
            break;
    }
}