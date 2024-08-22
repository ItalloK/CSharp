using System;
using Internal;

class Aula17{
    static void Main(){

        int[] Num = new int[5]; // Declarar Vetor.
        int[] Number = new int[5]{1,2,3,4,5}; // Declarar vetor definindo valores.
        //Num[0] = 111; -> Seta um valor diretamente
        int[] Num2={5,6,7,8,9}; // Outra forma, porem se tiver 5 numeros é [5];
        Num2[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor digitado é: {0}", Num2[0]);

        string[] Veiculos=new string[5];
        Veiculos[0] = "Carro";
        Veiculos[1] = "Moto";
        Veiculos[2] = "Barco";
        Veiculos[3] = "Bicicleta";
        Veiculos[4] = "Avião";
        Console.WriteLine("Veiculos cadastrados: {0},{1},{2},{3},{4}", Veiculos[0], Veiculos[1],Veiculos[2],Veiculos[3],Veiculos[4]);
    }
}