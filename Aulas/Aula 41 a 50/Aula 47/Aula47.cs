using System;

/* Sobrecarga de Metodos */

class Calc{
    public int soma(int n1, int n2){
        return n1+n2;
    }

    /* Pode ser criado varios metodos com o mesmo nome, desde que eles tenham lista de argumentos diferentes */

    public double soma(double n1, double n2){
        return n1+n2;
    }

    public int soma(params int[]n){
        int soma = 0;
        for(int i = 0; i < n.Length; i++){
            soma += n[i];
        }
        return soma;
    }
    public double soma(params double[]n){
        double soma = 0;
        for(int i = 0; i < n.Length; i++){
            soma += n[i];
        }
        return soma;
    }
}

class Aula47{
    static void Main(){

        Calc calc = new Calc();
        var res = calc.soma(10.2,5.4, 5, 7, 8.4, 9.2); // Pode ser declara VAR para n ter que definir entre int ou double
        Console.WriteLine(res);

    }
}