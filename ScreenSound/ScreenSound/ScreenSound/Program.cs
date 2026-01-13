Band linkinPark = new Band("Linkin Park");
Album meteora = new Album("Meteora");

Music music1 = new Music(linkinPark, "Numb")
{
    Duration = 185,
    AvaliableInYourPlan = true
};

Music music2 = new Music(linkinPark, "Faint")
{
    Duration = 162,
    AvaliableInYourPlan = false
};

meteora.AddMusic(music1);
meteora.AddMusic(music2);  

linkinPark.ShowBandDetails();
linkinPark.AddAlbum(meteora);
meteora.ShowAlbumDetails();

music1.ShowTechnicalSheet();
music2.ShowTechnicalSheet();
