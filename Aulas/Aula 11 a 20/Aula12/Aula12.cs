using System;
using Internal;

class Aula12{
    static void Main(){

        int Nota1, Nota2, Nota3, Nota4, Result = 0;
        string Resultado = "Reprovado";

        Console.Write("Digite a primeira nota do aluno: ");
        Nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota do aluno: ");
        Nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota do aluno: ");
        Nota3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota do aluno: ");
        Nota4 = int.Parse(Console.ReadLine());

        Result = Nota1+Nota2+Nota3+Nota4;

        if(Result >= 60){
            Resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {0}, Resultado: {1}", Result, Resultado);

    }
}