using System;
using System.Runtime.CompilerServices;
using Internal;

class Carro{
    private int velMax;
    public int vm{ // Isso aq é uma propriedade entao não usa ()
        get{ // Leitura
            return velMax;
        }
        set{ // Escrita
            if(value < 0){
                velMax = 0;
            }else if(value > 300){
                velMax = 300;
            }else{
                velMax = value;
            }
        }
    }
    public Carro(){
        vm = 120; // ta usando direto a propriedade
    }
}

class Aula41{
    static void Main(){
        Carro C1 = new Carro();
        C1.vm = 200; // Setou valor 200
        Console.WriteLine("Velocidade: {0}",C1.vm);        
    }
}