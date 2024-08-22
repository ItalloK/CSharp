using System;
using System.IO;
using System.Reflection.Emit;
using Internal;

class Veiculo{ // Classe Base
    public int Rodas;
    public int velMax;
    private bool Ligado;
    public void ligar(){
        Ligado = true;
    }
    public void desligar(){
        Ligado = false;
    }

    public string getLigado(){
        if(Ligado){
            return "Sim";
        }else{
            return "Não";
        }
    }
}
class Carro:Veiculo{ // Classe Derivada --> Derivada(Carro):Base(Veiculo) -
    public string Nome; // Se não definir como public ele não aparecerá em outras classes.
    public string Cor;
    public Carro(string Nome, string Cor){
        desligar();
        Rodas=4;
        velMax=120; 
        this.Nome=Nome;
        this.Cor=Cor;
    }
}


class Aula34{
    static void Main(){
        Carro c1 = new Carro("Corsa", "Amarelo");

        Console.WriteLine("Nome do carro: {0}", c1.Nome);
        Console.WriteLine("A cor do carro: {0}", c1.Cor);
        Console.WriteLine("Rodas: {0}", c1.Rodas);
        Console.WriteLine("Velocidade Maxima: {0}", c1.velMax);
        Console.WriteLine("Carro Ligado: {0}", c1.getLigado());

    }
}