using System;
using System.Globalization;
using Internal;

class Aula22{
    static void Main(){
        int[] Vetor =  new int[5]{1,3,5,7,9};
        /*for(int i = 0; i<Vetor.Length; i++){ // se usar <=  tem q user ( Vetor.Lenght-1 );
            Console.WriteLine(Vetor[i]);
        }*/
        foreach(int n in Vetor){ // Precisa ser do mesmo tipo do vetor. (só serve pra leitura, não pode ser utilizado pra leitura)
            Console.WriteLine(n);
        }
    }
}