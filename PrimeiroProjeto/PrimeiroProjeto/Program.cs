// Screen Sound Project - Band Registration System
string WelcomeMenssage = "Welcome to Screen Sound!";
//List<string> bandsList = new List<string> { "The Beatles", "Metalica"};

Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>
{
    {"Metalica", new List<int> {9, 9, 10 } },
    {"Linkin Park", new List<int> { 10, 8, 6 } },
    {"The Beatles", new List<int> { 10, 10, 6} }
};

registeredBands.Add("Audioslave", new List<int> { 10, 5, 4});

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
        case 3: RateBands();
            break;
        case 4: Console.WriteLine("You selected option " + optionChosenInt);
            break;
        case -1: Console.WriteLine("Goodbay! :)");
            break;
        default: Console.WriteLine("Invalid option selected.");
            break;
    }
}

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

void ShowOptionTitle(string title)
{
    int numberOfLetters = title.Length;
    string asterisks = string.Empty.PadLeft(numberOfLetters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void RegisterBand()
{
    Console.Clear();
    ShowOptionTitle("Register a Band");

    Console.Write("Enter the name of the band you want to register: ");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());

    Console.WriteLine($"The band {bandName} was registered successfully!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

void ShowRegisteredBands()
{
    Console.Clear();
    ShowOptionTitle("Showing registered bands");

    //for (int i = 0; i < bandsList.Count; i++)
    //{
    //    Console.WriteLine($"Band: {bandsList[i]}");
    //}

    foreach (string band in registeredBands.Keys)
    {
        Console.WriteLine($"Band: {band}");
    }

    Console.WriteLine("\nEnter any key for return to menu.");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}

void RateBands()
{
    Console.Clear();
    ShowOptionTitle("Rate a Band");

    Console.Write("Enter the name of band you want to rate: ");
    string bandName = Console.ReadLine()!;
    
    if (registeredBands.ContainsKey(bandName))
    {
        Console.Write($"What Score does the band {bandName} deserve? ");
        int rate = int.Parse(Console.ReadLine()!);
        registeredBands[bandName].Add(rate);
        Console.WriteLine($"\nThe Rate {rate} was registered successfuly for {bandName} band");
        Thread.Sleep(3500);
        Console.Clear();
        ShowMenuOptions();
    } else
    {
        Console.WriteLine($"\nThe band {bandName} not found.");
        Console.WriteLine("Press any key to go to the menu.");
        Console.ReadKey();
        Console.Clear();
        ShowMenuOptions();
    }
}

ShowMenuOptions();