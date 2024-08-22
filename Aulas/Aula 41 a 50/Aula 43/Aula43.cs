using System;

/* As interfaces só implementam metodos ( prototipos dos metodos )  */
/* Toda classe que implementar uma interace precisa obrigatoriamente implementar seus metodos */
/* Uma classe pode herdar quantas interfaces quiserem */

public interface Veiculo{ // Declarou interface
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo,Combate{ // Ta usando Interface -> Veiculo e Combate
    public bool ligado;
    private int municao;

    public Carro(){
        setMunicao(100);
    }

    public void setMunicao(int qtde){
        this.municao = qtde;
    }

    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void info(){
    }
    public void disparar(){
    }
}


class Aula43{
    static void Main(){
        Carro C1 = new Carro();
    }
}