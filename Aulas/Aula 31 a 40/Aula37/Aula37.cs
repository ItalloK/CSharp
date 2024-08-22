using System;
using Internal;

class Base{
    public Base(){
        Console.WriteLine("Construtor da Classe Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Classe Derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Classe Derivada2");
    }
}


class Aula37{
    static void Main(){

        Derivada2 D2 = new Derivada2();

        /*Ordem de execução é da classe base para a classe derivada*/

    }
}