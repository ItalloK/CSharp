using System;
using Internal;

class Aula15{
    static void Main(){
        int Tempo = 0;
        char Escolha;
        Console.WriteLine("(A) - Carro, (B) - Bicicleta, (C) - Caminhando");
        Console.WriteLine("Escolha a opção desejada: ");
        Escolha = char.Parse(Console.ReadLine());
        switch(Escolha){
            case 'a':
            case 'A':{
                Tempo = 20;
                break;
            }
            case 'b':
            case 'B':{
                Tempo = 60;
                break;
            }
            case 'c':
            case 'C':{
                Tempo = 120;
                break;
            }
            default:{
                Tempo = -1;
                break;
            }
        }
        if(Tempo < 0){
            Console.WriteLine("Você escolheu um transporte incorreto.");
        }else{
            Console.WriteLine("O tempo será de {0} minutos.", Tempo);
        }
    }
}