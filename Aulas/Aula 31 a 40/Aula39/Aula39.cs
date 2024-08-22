using System;

/*Quem herdar as classes abstratas é obrigado que implemente os metodos abstratos.*/

abstract class Veiculo{ // Definida como classe abstrata ( não é possivel criar instancias de classes abstratas, apenas heranças )
    protected int velMaxima;//protected pode ser acessada nas classes derivadas.
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }

    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMaxima = 120;
    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}

class Aula39{
    static void Main(){
        Carro Carro1 = new Carro();
        Carro1.aceleracao(1);
        Carro1.aceleracao(-1);
        Console.WriteLine(Carro1.getVelAtual());
    }
}