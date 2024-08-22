using System;
using Internal;

/* Métodos e Variáveis estáticos (static) */

class Mat{
    public static double pi = 3.14;
    public static int dobro (int n){
        return n*2;
    }

}


class Aula49{
    static void Main(){

        double vpi = Mat.pi; // n precisa declarar objeto nesse caso ( em membros static )
        int num = 10;
        Console.WriteLine("O valor de vpi é: {0}", vpi);
        Console.WriteLine("O dobro de {0} é: {1}", num, Mat.dobro(num));
    }
}