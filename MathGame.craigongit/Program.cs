using MathGame;
using Spectre.Console;

while (true)
{
    var userChoice = AnsiConsole.Prompt(
        new SelectionPrompt<UserOptions>()
            .Title("Select an option!")
            .AddChoices(Enum.GetValues<UserOptions>()));

    switch (userChoice)
    {
        case UserOptions.Addition:
            // Operations.Addition()
            break;
        case UserOptions.Subtraction:
            // Operations.Subtraction()
            break;
        case UserOptions.Multiplication:
            // Operations.Multiplication()
            break;
        case UserOptions.Division:
            // Operations.Division()
            break;
        case UserOptions.History:
            // Operations.History()
            break;
        case UserOptions.Quit:
            // Operations.Quit()
            break;
    }
}