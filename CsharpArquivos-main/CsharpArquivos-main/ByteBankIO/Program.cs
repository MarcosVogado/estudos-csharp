using ByteBankIO;
using System.Text;

 partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDoArquivo);

            //var linha = leitor.ReadLine();
            //var texto = leitor.ReadToEnd();
            //var numero = leitor.Read();

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"Titular: {contaCorrente.Titular}, Agência: {contaCorrente.Agencia}, Número: {contaCorrente.Numero}, Saldo: {contaCorrente.Saldo}";
                Console.WriteLine(msg);
            }

        }

        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');

        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2].Replace('.', ','));
        var titular = campos[3];

        var titularDaConta = new Cliente();
        titularDaConta.Nome = titular;

        var conta = new ContaCorrente(agencia, numero);
        conta.Depositar(saldo);

        return conta;
    }
}