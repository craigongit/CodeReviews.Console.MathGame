using MathGame;
using Spectre.Console;

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
            // operations.PlayGame();
            break;
        case Enums.UserOptions.History:
            // operations.ShowHistory();
        case Enums.UserOptions.Quit:
            Environment.Exit(0);
            break;
    }
}