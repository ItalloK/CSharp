using System;
using Internal;

class Galinha{
    private string Nome_Galinha;
    private int Num_Ovo;
    public Galinha(string Nome_Galinha){
        this.Nome_Galinha=Nome_Galinha;
        Num_Ovo = 0;
    }

    public Ovo botar(){ // Metodo que retorna Objeto
        Num_Ovo++;
        return new Ovo(Num_Ovo, Nome_Galinha);
    }
}

class Ovo{
    private int numOvo;
    private string MinhaGalinha;
    public Ovo(int numOvo, string MinhaGalinha){
        this.numOvo = numOvo;
        this.MinhaGalinha = MinhaGalinha;
        Console.WriteLine("Ovo Criado:{0} - Nome: {1}", this.numOvo, this.MinhaGalinha);
    }
}

class Aula46{
    static void Main(){

        Galinha g1 = new Galinha("Benedita");
        Galinha g2 = new Galinha("Maria");
        Galinha g3 = new Galinha("Mimosa");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();

        
    }
}