class Music
{
    public string name;
    public string artist;
    public int duration;
    private bool avaliableInYourPlan;

    public void SetAvaliableInYourPlan(bool avaliable)
    {
        avaliableInYourPlan = avaliable;
    }

    public bool GetAvaliableInYourPlan()
    {
        return avaliableInYourPlan;
    }

    public void ShowTechnicalSheet()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Duration: {duration}");
        if (avaliableInYourPlan)
        {
            Console.WriteLine("Available in your plan");

        }
        else
        {
            Console.WriteLine("Not available in your plan");
        }


    }
}
