class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool AvaliableInYourPlan { get; set; }
    public string Description 
    {
        get 
        {
            return $"The song {Name} belongs to {Artist}.";
        }
    }

    //public void SetAvaliableInYourPlan(bool avaliable)
    //{
    //    AvaliableInYourPlan = avaliable;
    //}

    //public bool GetAvaliableInYourPlan()
    //{
    //    return AvaliableInYourPlan;
    //}

    public void ShowTechnicalSheet()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        if (AvaliableInYourPlan)
        {
            Console.WriteLine("Available in your plan");
        }
        else
        {
            Console.WriteLine("Not available in your plan");
        }


    }
}
