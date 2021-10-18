using System;

namespace estudosSENAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Fabio", 27, 169, true);
            int i = Pessoa.getQuantidadePessoas();
            Console.WriteLine(i);
        }      
    }
}
