using System;

class Aula023{

    static void Main(){

        int [] vetor1 = new int [5];
        int [] vetor2 = new int [5];
        int [] vetor3 = new int [5];
        int [,] matriz = new int [2,5]{{11,22,00,44,55},{66,77,88,99,00}};
    

    Random random = new Random();
    for(int i = 0; i<vetor1.Length; i++){
        vetor1[i] = random.Next(50);
    }

    Console.WriteLine("Elementos do vetor1");
    foreach(int n in vetor1){
        Console.WriteLine(n);
    }

    //public static int BinarySearch(array, valor);
    Console.WriteLine("BinarySearch");
    int procurado = 33;
    int pos = Array.BinarySearch(vetor1,procurado);
    Console.WriteLine("O valor {0} está na posição {1}", procurado, pos);
    Console.WriteLine("-"*20);
    

    //public static void copy(Ar_origem, Ar_destino, qtd_elementos);
    Console.WriteLine("Copy");
    Array.Copy(vetor1, vetor2, vetor1.Length);
    foreach(int n in vetor2){
        Console.WriteLine(n);
    }
    Console.WriteLine("-"*20);

    //public static void CopyTo(Ar_destino, a_partir_desta_pos);
    Console.WriteLine("CopyTo");
    vetor1.CopyTo(vetor3, 0);
    foreach (int i in vetor3){
        Console.WriteLine(i);
    }
    Console.WriteLine("-"*20);
   
   






}
}