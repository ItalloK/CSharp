using System;
using Internal;


class Veiculo{ // Classe Base
    public int velAtual;
    private int velMax; // private restringe o acesso apenas a Classe.
    protected bool ligado; // Permite o acesso da classe BASE(essa) e tambem nas classes Derivadas ( Apenas nas classes );

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false; 
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{ // Derivada de Veiculo
    public string Nome;
/*  Como na classe veiculo tem o int velMax, aqui precisa atribuir uma base no public Carro, o valor inserido é o referente a
    velMax  */
    public Carro(string Nome, int vm):base(vm){
        this.Nome = Nome;
        ligado=true;
    }
}


class Aula36{
    static void Main(){
        
        Carro carro = new Carro("Corola", 120);

        Console.WriteLine("Nome......: {0}", carro.Nome);
        Console.WriteLine("Vel Maxima: {0}", carro.getVelMax());
        Console.WriteLine("Ligado....: {0}", carro.getLigado());


    }
}