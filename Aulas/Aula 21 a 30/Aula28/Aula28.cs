using System;
using Internal;

/*Se a classe não tiver metodos, ela é publica automaticamente*/

public class Jogador{ // iniciar classes com letras maiusculas ( boa pratica de programação )

    public int Energia = 100; /*Se a variavel não tiver metodos, ela é public automaticamente*/
    public bool Vivo = true;

}

class Aula28{
    static void Main(){

        Jogador J1 = new Jogador();
        Jogador J2 = new Jogador();
        Jogador J3 = new Jogador();

        J1.Energia = 50; // Como é propriedade publica, pode ser alterada.

        Console.WriteLine("Energia do Jogador 1: {0}", J1.Energia);
        Console.WriteLine("Energia do Jogador 1: {0}", J2.Energia);

    }     
}