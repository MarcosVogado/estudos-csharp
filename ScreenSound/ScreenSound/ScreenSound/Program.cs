Album meteora = new Album();
meteora.Name = "Meteora";

Music music1 = new Music();
music1.Name = "Numb";
music1.Duration = 185;

Music music2 = new Music();
music2.Name = "Faint";
music2.Duration = 162;

meteora.AddMusic(music1);
meteora.AddMusic(music2);

Band linkinPark = new Band();
linkinPark.Name = "Linkin Park";
linkinPark.AddAlbum(meteora);
linkinPark.ShowBandDetails();