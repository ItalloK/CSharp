using System;

class Veiculo{ // Classe Base
    private int Rodas;
    public int velMax;
    private bool Ligado;

    public Veiculo(int Rodas){
        this.Rodas = Rodas;
    }

    public void ligar(){
        Ligado = true;
    }
    public void desligar(){
        Ligado = false;
    }

    public string getLigado(){
        return (Ligado?"Sim":"Não"); // Ternario
    }

    public int getRodas(){
        return Rodas;
    }

    public void setRodas(int Rodas){
        if(Rodas<0){
            this.Rodas = 0;
        }else if(Rodas>40){
            this.Rodas = 40;
        }else{
            this.Rodas=Rodas;
        }

    }
}
class Carro:Veiculo{ // Classe Derivada --> Derivada(Carro):Base(Veiculo) -
    public string Nome; // Se não definir como public ele não aparecerá em outras classes.
    public string Cor;
    public Carro(string Nome, string Cor):base(4){
        desligar();

        velMax=120; 
        this.Nome=Nome;
        this.Cor=Cor;
    }

}


class CarroCombate:Carro{ // Oq tiver public em Veiculo pode ser usado aqui e em class Carro;

    public int municao;
    public CarroCombate():base("Carro de Combate", "Rosa"){
        municao = 100;
        setRodas(6);
    }

}


class Aula35{
    static void Main(){
        Carro c1 = new Carro("Corsa", "Amarelo");

        CarroCombate c2 = new CarroCombate();

        c1.ligar();

        Console.WriteLine("Nome do carro: {0}", c1.Nome);
        Console.WriteLine("A cor do carro: {0}", c1.Cor);
        Console.WriteLine("Rodas: {0}", c1.getRodas());
        Console.WriteLine("Velocidade Maxima: {0}", c1.velMax);
        Console.WriteLine("Carro Ligado: {0}", c1.getLigado());

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine("Nome do carro: {0}", c2.Nome);
        Console.WriteLine("A cor do carro: {0}", c2.Cor);
        Console.WriteLine("Rodas: {0}", c2.getRodas());
        Console.WriteLine("Velocidade Maxima: {0}", c2.velMax);
        Console.WriteLine("Carro Ligado: {0}", c2.getLigado());
        Console.WriteLine("Munição: {0}", c2.municao);


    }
}