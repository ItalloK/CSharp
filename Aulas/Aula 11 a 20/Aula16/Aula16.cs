using System;
using Internal;

class Aula16{
    static void Main(){
        int Tempo = 0;
        char Escolha;
        inicio: // Label para uso do Goto
        Console.Clear();
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
        Console.Write("Você deseja tentar novamente? [S/N]: ");
        Escolha = char.Parse(Console.ReadLine());
        if(Escolha == 's' || Escolha == 'S'){
            goto inicio; // Volta pra linha do Inicio.
        }else{
            Console.Clear();
            Console.WriteLine("Fim do programa.");
        }
    }
}