using System;

struct Carro{
    public string Modelo;
    public string Cor;
    public void info(){
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Modelo: {0}, Cor: {1}", this.Modelo, this.Cor);
        Console.WriteLine("----------------------------------------------------------------------");
    }
}


class Aula45{
    static void Main(){

        Carro[] carros = new Carro[4]; // Declara como vetor

        carros[0].Modelo = "Civic";
        carros[0].Cor = "Branco";
        carros[1].Modelo = "Chevete";
        carros[1].Cor = "Rosa";
        carros[2].Modelo = "Fusca";
        carros[2].Cor = "Azul";
        carros[3].Modelo = "Fusca";
        carros[3].Cor = "Azul";

        for(int i = 0; i<carros.Length; i++){ // Assim 
            carros[i].info();
        }

        carros[0].info(); // ou assim
        carros[1].info();
        carros[2].info();

        

    }
}