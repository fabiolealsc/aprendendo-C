using System;
class Aula008
{
    static void Main()
    {
        int n1, n2, soma;
        string nome = "Fabio";
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());
        soma = n1 + n2;
        Console.WriteLine("A soma dos dois números é: " + soma);
        Console.WriteLine("Obrigado por utilizar esse programa " + nome);
    }
}
