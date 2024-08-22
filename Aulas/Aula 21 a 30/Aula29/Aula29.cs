using System;
using Internal;

/*Se a classe não tiver metodos, ela é publica automaticamente*/

public class Jogador{ // iniciar classes com letras maiusculas ( boa pratica de programação )
    public int Energia; /*Se a variavel não tiver metodos, ela é public automaticamente*/
    public bool Vivo;
    public string Nome;
    public Jogador(string N){ // Metodo Construtor
        Energia = 100;
        Vivo = true;
        Nome = N;
    }
    ~Jogador(){ // Metodo Destrutor
        Console.WriteLine("Jogador {0} foi Destruido", Nome);
    }
}

class Aula29{
    static void Main(){

        string Nome1;
        Console.Write("Digite o nome do Jogador 1: ");
        Nome1 = Console.ReadLine();
        Jogador J1 = new Jogador(Nome1);
        Console.WriteLine("Energia do Jogador 1: {0} com nome: {1}", J1.Energia, J1.Nome);

        J1.Energia = 50; // Como é propriedade publica, pode ser alterada.
        //Jogador J1 = new Jogador("Italo"); -> pode ser feito assim
        // Console.WriteLine("Energia do Jogador 1: {0} com nome: {1}", J1.Energia, J1.Nome); -> feito pelo de cima

    }     
}