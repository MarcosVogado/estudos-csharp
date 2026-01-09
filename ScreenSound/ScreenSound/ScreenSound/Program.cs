Music musica1 = new Music();
musica1.name = "Unforgiven";
musica1.artist = "Metallica";
musica1.duration = 420;
musica1.avaliableInYourPlan = true;

//Console.WriteLine($"Name: {musica1.name}");
//Console.WriteLine($"Artist: {musica1.artist}");

musica1.ShowTechnicalSheet();

Music musica2 = new Music();
musica2.name = "Like a Stone";
musica2.artist = "Audioslave";
musica2.duration = 350;
musica2.avaliableInYourPlan = false;

//Console.WriteLine($"\nName: {musica1.name}");
//Console.WriteLine($"Artist: {musica1.artist}");

musica2.ShowTechnicalSheet();