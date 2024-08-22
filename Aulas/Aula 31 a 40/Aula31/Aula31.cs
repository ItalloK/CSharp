using System;
using Internal;

/*Se a classe não tiver metodos, ela é publica automaticamente*/

static class Jogador{ // iniciar classes com letras maiusculas ( boa pratica de programação )
    static public int Energia; /*Se a variavel não tiver metodos, ela é public automaticamente*/
    static public bool Vivo;
    static public string Nome;

    static public void iniciar(string n){
        Energia = 100;
        Vivo = true;
        Nome = n;
    }
    static public void Info(){
        Console.WriteLine("Nome jogador: {0}", Nome);
        Console.WriteLine("Energia Jogador: {0}", Energia);
        Console.WriteLine("Status jogador: {0}\n", Vivo);
    }
}

class Inimigo{
    static public bool Alerta;
    public string nome;

    public Inimigo(string n){
        Alerta = false;
        nome = n;
    }

    public void Info(){
        Console.WriteLine("Nome inimigo: {0}", nome);
        Console.WriteLine(Alerta);
        Console.WriteLine("-------------------------");
    }
}

class Aula31{
    static void Main(){

        Jogador.iniciar("Bruno");
        Jogador.Info();

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluko");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.Alerta = true;

        i1.Info();
        i2.Info();
        i3.Info();

    }     
}