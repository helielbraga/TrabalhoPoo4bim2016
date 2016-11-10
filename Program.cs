using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Vitoria campinas = new Pessoa.Vitoria("Vitoria", "branca", 21, 1.6, 65);
            Ana pirassununga = new Pessoa.Ana("Ana", "Morena", 40, 1.7, 90);

            Console.WriteLine("::Caracteristicas da "+campinas.nome+"::\n");
            Console.WriteLine("Cor: "+campinas.cor);
            Console.WriteLine("Idade: " + campinas.idade);
            Console.WriteLine("Tamanho: " + campinas.tamanho);
            Console.WriteLine("Peso: " + campinas.peso);

            Console.WriteLine("\n\n::Caracteristicas da " + pirassununga.nome + "::\n");
            Console.WriteLine("Cor: " + pirassununga.cor);
            Console.WriteLine("Idade: " + pirassununga.idade);
            Console.WriteLine("Tamanho: " + pirassununga.tamanho);
            Console.WriteLine("Peso: " + pirassununga.peso);
            Console.Read();
        }
    }
}
