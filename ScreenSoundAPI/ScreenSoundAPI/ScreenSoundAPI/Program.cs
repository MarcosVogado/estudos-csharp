using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    }
    catch (Exception excecao)
    {
        Console.WriteLine("Ocorreu um erro ao acessar a API: " + excecao.Message);
    }
}