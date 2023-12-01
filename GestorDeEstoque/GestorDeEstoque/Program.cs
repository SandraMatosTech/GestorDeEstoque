using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoque
{
    internal class Program
    {
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }

        static void Main(string[] args)
        {
        Console.Write("Sistema de estoque");
            Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Entrada\n5-Saída\n6-Sair");
        }
    }
}
