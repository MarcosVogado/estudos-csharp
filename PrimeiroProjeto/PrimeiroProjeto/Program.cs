// Screen Sound
void ShowWelcomeMessage()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}

void ShowMenuOptions()
{
    Console.WriteLine("Welcome to Screen Sound!");

    Console.WriteLine("\nEnter (1) => for register a band");
    Console.WriteLine("Enter (2) => for show all bands");
    Console.WriteLine("Enter (3) => for evaluate a band");
    Console.WriteLine("Enter (4) => for show a band average");
    Console.WriteLine("Enter (-1) => for exit");

    Console.Write("\nSelect an option: ");
    string optionChosen = Console.ReadLine()!;
    int optionChosenInt = int.Parse(optionChosen);

    switch (optionChosenInt)
    {
        case 1: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case 2: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case 3: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case 4: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case -1: Console.WriteLine("Goodbay! :(");
            break;
        default: Console.WriteLine("Invalid option selected.");
            break;
    }
}

ShowWelcomeMessage();
ShowMenuOptions();