using System;

class Aula03{
    static void Main(){

        /*byte n1 = 10; // Entre 0 e 255 ( não permite negativo )
        int Num = 0;
        char Letra = 'C';
        float Valor = 5.3f;
        string Nome = "Italo";
        var aux = Nome;*/

        int Num1, Num2, Resultado;
        Num1 = 10;
        Num2 = 5;
        Resultado = Num1+Num2;

        //Console.Write(Num); // Write -> Não Pula Linha

        Console.WriteLine("A Soma de " +  Num1 + " mais " + Num2 + " é igual a: " + Resultado); // WriteLine -> Pula Linha

        Console.WriteLine("A Soma de " +  Num1 + " mais " + Num2 + " é igual a: " + (Num1+Num2)); 
    }
}