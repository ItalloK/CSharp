using System;
using Internal;

struct Carro{
    public string Marca;
    public string Modelo;
    public string Cor;

    public Carro(string Marca, string Modelo, string Cor){
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Cor = Cor;
    }

    public void info(){
        Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}", this.Marca, this.Modelo, this.Cor);
    }
}


class Aula44{
    static void Main(){
        Carro C1;
        C1.Marca = "Volks";
        C1.Modelo = "Golf";
        C1.Cor = "Azul";
        Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}", C1.Marca, C1.Modelo, C1.Cor);

        C1.info(); // Outra Forma ( Imprime as Infos )

        Carro C2 = new Carro("Honda", "HRV", "Prata"); // Usando Construtor
        Console.WriteLine("Marca: {0}, Modelo: {1}, Cor: {2}", C2.Marca, C2.Modelo, C2.Cor);
    }
}