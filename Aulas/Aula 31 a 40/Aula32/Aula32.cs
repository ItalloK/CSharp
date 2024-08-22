using System;
using Internal;

public class Calculos{
    public int v1;
    public int v2;
    public Calculos(int v1, int v2){
        this.v1 = v1; // This diz que o V1 do metodo é o V1 do inicio.
        this.v2 = v2; // This diz que o V2 do metodo é o V2 do inicio.
    }
    public int somar(){
        return v1+v2;
    }
}

public class Aula32{
    static void Main(){

        Calculos C = new Calculos(10,2);
        Console.WriteLine(C.somar()); // Imprime a soma dos valores passados acima.

    }
}