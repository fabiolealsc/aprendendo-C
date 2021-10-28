using System;
class Aula010
{
    enum DiaSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }
    static void Main()
    {
        int ds=(int)DiaSemana.Sexta;
        //DiaSemana ds = (DiaSemana)3;
        
        Console.WriteLine(ds);
    }
}