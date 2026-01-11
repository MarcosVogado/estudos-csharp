Music musica1 = new Music();
musica1.Name = "Unforgiven";
musica1.Artist = "Metallica";
musica1.Duration = 420;
musica1.SetAvaliableInYourPlan(true);

//Console.WriteLine($"Name: {musica1.name}");
//Console.WriteLine($"Artist: {musica1.artist}");

Console.WriteLine(musica1.Description);
musica1.ShowTechnicalSheet();

Music musica2 = new Music();
musica2.Name = "Like a Stone";
musica2.Artist = "Audioslave";
musica2.Duration = 350;
musica2.SetAvaliableInYourPlan(false);

//Console.WriteLine($"\nName: {musica1.name}");
//Console.WriteLine($"Artist: {musica1.artist}");

Console.WriteLine(musica2.Description);
musica2.ShowTechnicalSheet();