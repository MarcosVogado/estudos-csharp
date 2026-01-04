// Screen Sound
string WelcomeMenssage = "Welcome to Screen Sound!";
List<string> bandsList = new List<string> { "The Beatles", "Metalica"};
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
    Console.WriteLine(WelcomeMenssage);

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
        case 2: ShowRegisteredBands();
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
    Console.WriteLine(" ******************");
    Console.WriteLine("  Register a Band");
    Console.WriteLine(" ******************\n");

    Console.Write("Enter the name of the band you want to register: ");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName);

    Console.WriteLine($"The band {bandName} was registered successfully!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

void ShowRegisteredBands()
{
    Console.Clear();
    Console.WriteLine(" **************************");
    Console.WriteLine("  Showing registered bands");
    Console.WriteLine(" **************************\n");

    for (int i = 0; i < bandsList.Count; i++)
    {
        Console.WriteLine($"Band: {bandsList[i]}");
    }

    Console.WriteLine("\nEnter any key for return to menu");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}

ShowMenuOptions();