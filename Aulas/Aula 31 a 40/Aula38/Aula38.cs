using System;

/*Metodo Virtual: São metodos que tem o mesmo nome em classes diferentes, porem esse metodo vai executar uma ação diferente
Deve ser definido na classe base que esse metodo vai ser virtual e que podera ser sobrescrito numa classe derivada.*/

class Base{
    public Base(){
        Console.WriteLine("Construtor da Classe Base");
    }
    virtual public void Info(){ // Criou um metodo virtual
        Console.WriteLine("Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Classe Derivada 1");
    }
    override public void Info(){ // Sobreescreveu
        Console.WriteLine("Derivada 1");
    }

}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Classe Derivada 2");
    }
    override public void Info(){ // Sobreescreveu
        Console.WriteLine("Derivada 2");
    }
}


class Aula38{
    static void Main(){

        Base Ref; // Cria um elemento de referencia que pode receber as classes derivadas dessa base.

        Derivada1 D1 = new Derivada1();
        Derivada2 D2 = new Derivada2();
        
        Ref=D1;
        Ref.Info(); // Chama o metodo info de derivada 1.

    }
}