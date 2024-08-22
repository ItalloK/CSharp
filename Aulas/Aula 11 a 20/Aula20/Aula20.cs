using System;
using Internal;

class Aula20{
    static void Main(){
        int[] Num = new int [10];
        int[,] Matriz = new int [5,5];
        // int i = 0; -> Posso fazer assim 
        int i = Num.Length - 1; // Ou assim  ( funciona com o i-- )
        while(i < Num.Length){
            Num[i] = 0;
            Console.WriteLine(Num[i]);
            i++;
        }
    }
}