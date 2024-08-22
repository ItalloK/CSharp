using System;
using Internal;

class Aula09{
    static void Main(){
        
        /*Operadores Bitwise: 
            ( >> ) -> Dobra o valor da Variavel
            ( << ) -> Metade do valor da Variavel
        */
        int Num = 2;
        Num = Num << 2;
        Console.WriteLine("Valor: {0}", Num);
    }
}