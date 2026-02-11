using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
        var buffer = new byte[1024]; //1Kb

        // public override int Read(byte[] buffer, int offset, int count)
        fluxoDoArquivo.Read(buffer, 0, 1024);

        Console.ReadLine();
    }
}