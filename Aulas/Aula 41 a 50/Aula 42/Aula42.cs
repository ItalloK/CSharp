using System;

/*Indexadores == Permite o Objeto ser definido como Array */

class Carro{
    private int[] velMax = new int[5]{80, 120, 160, 240, 300};
    public int this[int i]{
        get{ 
            return velMax[i];
        }
        set{ 
            if(value < 0){
                velMax[i] = 0;
            }else if(value > 300){
                velMax[i] = 300;
            }else{
                velMax[i] = value;
            }
        }
    }
    public Carro(){
    }
}

class Aula42{
    static void Main(){
        Carro C1 = new Carro();

        C1[4] = 200; 
        Console.WriteLine("Velocidade: {0}",C1[4]);        
    }
}