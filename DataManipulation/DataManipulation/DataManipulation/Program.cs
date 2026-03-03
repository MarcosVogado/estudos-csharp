using System.Collections;

namespace DataManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var diasDaSemana = new DiasDaSemana();

            var carrinho = new List<Produto>()
            {
                new Produto { Titulo = "Livro", Preco = 29.90 },
                new Produto { Titulo = "Caderno", Preco = 9.90 },
                new Produto { Titulo = "Caneta", Preco = 4.90 }
            };

            foreach (var dias in diasDaSemana)
            {
                Console.WriteLine(dias);
            }

            //PercorrendoComForeach();

            void PercorrendoComForeach()
            {
                foreach (var produto in carrinho)
                {
                    Console.WriteLine($"Produto: {produto.Titulo}");
                }
            }

            void PercorrendoComFor()
            {
                for (int i = 0; i < carrinho.Count; i++)
                {
                    Console.WriteLine($"Produto: {carrinho[i].Titulo}");
                }
            }
        }
    }

    class Produto
    {
        public string Titulo { get; set; }
        public double Preco { get; set; }

    }

    class DiasDaSemanaEnumerator : IEnumerator<string>
    {
        private int posicao = -1;
        private string[] dias = new string[]
        {
            "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"
        };
        public string Current => dias[posicao];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            posicao++;
            return posicao < dias.Length;
        }

        public void Reset()
        {
            posicao = -1;
        }
    }

    class DiasDaSemana : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            return new DiasDaSemanaEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
