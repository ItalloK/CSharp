using System;

/* Recursividade - Função chamando ela mesma */

class Calc{
    public int soma(int n1, int n2){
        return n1+n2;
    }

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
    public int fat(int n){ // Recursividade
        int res;
        if(n <= 1){
            res = 1;
        }else{
            res=n*fat(n-1);
        }
        return res;
    }
}

class Aula48{
    static void Main(){

        Calc calc = new Calc();
        var res = calc.fat(10); // Calcula o Fatorial do Numero
        Console.WriteLine(res);

    }
}