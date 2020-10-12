using System;
using System.Globalization;

namespace POO_TarefaEncapsulamentoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto a=new Produto("PS5",6000.00,10);

            a.Nome = "XBOX X";

            Console.WriteLine("Nome do Produto: " + a.Nome);
            Console.WriteLine("Preço do Produto: R$ " + a._preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade: " + a._quantidade + " Unidades");

            Console.ReadKey();
        }
    }
}
