using System;
using Internal;

class Aula26{
    static void Main(){
        int Num = 10;
        //dobrar(Num); // Passagem por Valor, Ref usa o endereço de memoria.
        dobrar(ref Num); // Passagem por Referencia
        Console.WriteLine(Num);     
    }
    static void dobrar(ref int valor){ // ou só int valor
        valor *= 2;        
    }
}