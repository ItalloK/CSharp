using System;
using Internal;

class Aula14{
    static void Main(){
        int Nota1, Nota2, Result = 0;
        string Resultado = "";

        Console.Write("Digite a primeira nota do aluno: ");
        Nota1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota do aluno: ");
        Nota2 = int.Parse(Console.ReadLine());
        Result = Nota1+Nota2+Nota3+Nota4;
        // >= 60 -> Aprovado 
        // 59 e 40  -> Recuperação  
        // < 40 -> Reprovado
        if(Result >= 60){
            Resultado = "Aprovado";
            if(Result > 80){
                Console.WriteLine("Você passou com Honras");
            }
        }else if(Result > 40 || Result <= 59){
            Resultado = "Recuperação";
        }else if(Result < 40){
            Resultado = "Reprovado";
        }
        Console.WriteLine("Nota: {0}, Resultado: {1}", Result, Resultado);
    }
}