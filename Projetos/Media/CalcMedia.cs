using System;
using Internal;

class CalcMedia{
    static void Main(){
        int Quant_Notas;
        float Notas = 0f, Media = 0f, Total_Notas = 0f;
        do{
            Console.Write("Qual a quantidade de notas que deseja calcular a Media: ");
            Quant_Notas = int.Parse(Console.ReadLine());
            if(Quant_Notas <= 0) Console.WriteLine("ERRO: Você digitou um valor menor que 0, digite novamente.");
        }while(Quant_Notas <= 0);
        for(int i = 0; i<Quant_Notas; i++){
            do{
                Console.Write("Digite a {0} nota: ", i+1);
                Notas = float.Parse(Console.ReadLine());
                if(Notas < 0) Console.WriteLine("ERRO: Você digitou uma nota menor que 0, digite novamente.");
                if(Notas > 10) Console.WriteLine("ERRO: Você digitou uma nota maior que 10, digite novamente.");
            }while(Notas < 0 || Notas > 10);
            Total_Notas += Notas;
        }
        Media = Total_Notas/Quant_Notas;
        Console.WriteLine("A Media das notas digitadas é: {0}", Media);
    }
}