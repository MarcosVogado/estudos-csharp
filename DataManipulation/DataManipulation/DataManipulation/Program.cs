using System.Collections;

namespace DataManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var diasDaSemana = new string[]
            { 
                "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" 
            };

            var carrinho = new ArrayList()
            {
                new Produto { Titulo = "Livro", Preco = 29.90 },
                new Produto { Titulo = "Caderno", Preco = 9.90 },
                new Produto { Titulo = "Caneta", Preco = 4.90 }
            };
        }
    }

    class Produto
    {
        public string Titulo { get; set; }
        public double Preco { get; set; }

    }
}
