using System;
using Internal;

class Aula05{

    static void Main(){

        int Resultado = (10 + 5)*10;
        //bool Result = 10<5; -> Retorna False
        bool Result = 10!=5; // -> Retorna True
        int num = 10;
        //num = num + 1; -> incremento basico || num += 1; -> Incremento += || num++; // Incremento ++

        /*Operadores Logicos: 
        & -> and ( bit a bit )
        && -> and ( and Logico )
        | -> or ( bit a bit )
        || -> ( or Logico )
        */

        bool Teste = (5>3)||(5<2);

        Console.WriteLine(Teste);


    }


}