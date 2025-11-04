using MathGame;
using Spectre.Console;

var operations = new Operations();

while (true)
{
    Console.Clear();
    
    var userChoice = AnsiConsole.Prompt(
        new SelectionPrompt<UserOptions>()
            .Title("Select an option!")
            .AddChoices(Enum.GetValues<UserOptions>()));

    switch (userChoice)
    {
        case UserOptions.Addition:
            operations.Addition();
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
            operations.ShowHistory();
            break;
        case UserOptions.Quit:
            // Operations.Quit()
            break;
    }
}