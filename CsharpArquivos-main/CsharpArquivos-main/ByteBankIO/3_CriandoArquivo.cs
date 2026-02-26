using System.Text;

partial class Program
{
    static void CriandoArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.cvs";
        
        using(var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456,7895,1000.50,João Silva";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }
}