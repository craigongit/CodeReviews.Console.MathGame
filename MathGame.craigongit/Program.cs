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
            operations.Subtraction();
            break;
        case UserOptions.Multiplication:
            operations.Multiplication();
            break;
        case UserOptions.Division:
            operations.Division();
            break;
        case UserOptions.History:
            operations.ShowHistory();
            break;
        case UserOptions.Quit:
            Environment.Exit(0);
            break;
    }
}