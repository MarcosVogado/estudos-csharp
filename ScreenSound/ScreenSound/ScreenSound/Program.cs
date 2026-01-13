Band linkinPark = new Band();
linkinPark.Name = "Linkin Park";

Album meteora = new Album();
meteora.Name = "Meteora";

Music music1 = new Music(linkinPark);
music1.Name = "Numb";
music1.Duration = 185;

Music music2 = new Music(linkinPark);
music2.Name = "Faint";
music2.Duration = 162;

meteora.AddMusic(music1);
meteora.AddMusic(music2);

linkinPark.AddAlbum(meteora);
linkinPark.ShowBandDetails();