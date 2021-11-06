using System;

class aula024{

    static void Main(){
        soma(10,5,4,3,2,1);

    }

    static void soma(params int[]n){
        int res = 0;

        if (n.Length < 1){
            Console.WriteLine("Nenhum valor informado");}
        
        else if (n.Length == 1){
            Console.WriteLine("O valor informado é {0}", n[0]);}
        
        else{
            for (int i = 0; i < n.Length; i++){
                res += n[i];
            }
            Console.WriteLine("A soma dos valores informados é {0}", res);
        }
    }


}