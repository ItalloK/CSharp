using System;
using Internal;

/* Delegates - Objeto que faz referencia a Metodos */

delegate int Op(int n1, int n2); // Declarou o Delegate como INTEIRO

class Mat{
    public static int soma(int n1, int n2){
        return n1+n2;
    }
    public static int mult(int n1, int n2){
        return n1*n2;
    }


}

class Aula50{
    static void Main(){

        int res;

        Op D1 = new Op(Mat.soma); // Usando Delegate para Soma
        res = D1(10,50);
        Console.WriteLine("Soma: {0}", res);


        Op D1 = new Op(Mat.soma); // Usando Delegate para Multiplicação
        D1 = new Op(Mat.mult); 
        res = D1(10,50);
        Console.WriteLine("Multiplicação: {0}", res);
        
    }
}