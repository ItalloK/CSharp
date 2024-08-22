using System;
using Internal;

class Jogador{
    private int Energia;
    private string Nome; // Private não deixa ser alterado de fora da classe

    public Jogador(string Nome){
        this.Nome=Nome;
        Energia = 100;
    }

    public int getEnergia(){
        return Energia;
    }
    public string getNome(){
        return Nome;
    }

    public void setEnergia(int e){
        if(e < 0){
            if(Energia+e < 0){
                Energia = 0;
            }else{
                Energia += e;
            }
        }else if(e > 0){
            if(Energia+e > 100){
                Energia = 100;
            }else{
                Energia += e;
            }
        }
    }

}

class Aula33{
    static void Main(){

        Jogador J1 = new Jogador("Italo");

        J1.setEnergia(-150);

        Console.WriteLine("Nome: {0}", J1.getNome());
        Console.WriteLine("Energia: {0}", J1.getEnergia());


    }
}