using System;
using Internal;

class Aula24{
    static void Main(){
        int[] Num = new int[3];
        Console.WriteLine("Digite o primeiro numero: ");
        Num[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        Num[1] = int.Parse(Console.ReadLine());

        Num[2] = Soma(Num[0], Num[1]);
        
        Console.WriteLine("O valor da soma é: {0}", Num[2]);
        Console.WriteLine("O valor da soma é: {0}", Soma(Num[0], Num[1])); // Poder ser usado assim tambem.
    }
    static void Nome(){ // Metodo static pq o Main é static
        Console.WriteLine("Italluzinho");
    }
    static int Soma(int n1, int n2){ // Retorno obrigatorio ser o int ( se for float é float)
        int Soma = n1+n2;
        return Soma;
    }
}