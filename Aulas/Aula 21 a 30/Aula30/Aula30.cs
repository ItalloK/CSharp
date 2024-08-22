using System;
using Internal;

/*Se a classe não tiver metodos, ela é publica automaticamente*/

public class Jogador{ // iniciar classes com letras maiusculas ( boa pratica de programação )
    public int Energia; /*Se a variavel não tiver metodos, ela é public automaticamente*/
    public bool Vivo;
    public string Nome;

    public Jogador(){
        Energia = 100;
        Vivo = true;
        Nome = "Jogador";
    }

    public Jogador(string N){ // Metodo Construtor
        Energia = 100;
        Vivo = true;
        Nome = N;
    }

    public Jogador(string N, int E){ 
        Energia = E;
        Vivo = true;
        Nome = N;
    }

    public Jogador(string N, int E, bool V){ 
        Energia = E;
        Vivo = V;
        Nome = N;
    }

    public void Info(){
        Console.WriteLine("Nome jogador: {0}", Nome);
        Console.WriteLine("Energia Jogador: {0}", Energia);
        Console.WriteLine("Status jogador: {0}\n", Vivo);
    }
}

class Aula30{
    static void Main(){

        Jogador J1 = new Jogador();
        Jogador J2 = new Jogador("Gabriel");
        Jogador J3 = new Jogador("Italo", 100);
        Jogador J4 = new Jogador("José", 0, false);

        J1.Info();
        J2.Info();
        J3.Info();
        J4.Info();
        

    }     
}