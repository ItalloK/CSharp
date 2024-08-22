using System;
using Internal;

class Aula08{

    static void Main(){
        
        int Valor1, Valor2, Soma;
        string Nome;
        Console.WriteLine("Digite o primeiro numero: ");
        Valor1 = int.Parse(Console.ReadLine()); // Para converter e aceitar o valor em Inteiro.
        Console.WriteLine("Digite o segundo numero: ");
        Valor2 = Convert.ToInt32(Console.ReadLine()); // Para converter e aceitar o valor em Inteiro.
        Soma = Valor1+Valor2;
        Console.WriteLine("A soma de {0} + {1} é: {2}", Valor1, Valor2, Soma);

    }

}