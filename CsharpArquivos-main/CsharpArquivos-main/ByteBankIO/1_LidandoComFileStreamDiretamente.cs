using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1Kb

            //Voltei aos estudos fi, agora ninguém mais segura a máquina.
            // public override int Read(byte[] buffer, int offset, int count)
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();
            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);

            /*
            foreach (var meuBite in buffer)
            {
                Console.Write(meuBite);
                Console.Write(" ");
            }
            */
        }
    }

}