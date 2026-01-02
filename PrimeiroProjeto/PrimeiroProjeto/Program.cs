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
    ShowWelcomeMessage();
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
        case 1: RegisterBand();
            break;
        case 2: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case 3: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case 4: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case -1: Console.WriteLine("Goodbay! :)");
            break;
        default: Console.WriteLine("Invalid option selected.");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("*** Register a Band ***");
    Console.Write("Enter the name of the band you want to register: ");
    string bandName = Console.ReadLine()!;
    Console.WriteLine($"The band {bandName} was registered successfully!");
    Thread.Sleep(5000);
    Console.Clear();
    ShowMenuOptions();
}

ShowMenuOptions();