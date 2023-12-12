using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoque
{
    [System.Serializable]

    class Curso : Produto, IEstoque
	{
		public string autor;
		private int vagas;

		public Curso(string nome, string autor, float preco)
		{
			this.autor = autor;
			this.nome = nome;
			this.preco = preco;


		}

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no curso: {nome}");
            Console.WriteLine("Digite a quantidade de vagas que você quer dá entrada:");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            throw new NotImplementedException();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("=============================");




        }
    }
}
