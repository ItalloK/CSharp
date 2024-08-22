using System;
using Internal;

class Aula19{
    static void Main(){
        int[] Num = new int [10];

        int[,] Matriz = new int [5,5];

        for(int i=0; i<Num.Length; i++){ // Num.Length -> Retorna o tamanho em INT do vetor.
            Num[i] = 15;
        }

        for(int i=0; i<10; i++){
            Console.WriteLine(Num[i]);
        }
    }
}