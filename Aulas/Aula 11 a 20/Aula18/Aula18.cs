using System;
using Internal;

class Aula18{
    static void Main(){

        int[,] Matriz = new int[3,5]; // Declaração basica

        int[,] Matriz2 = new int[2,2]{{10,20},{30,40}}; // Declarando com valores.

        /*      TABELA:
            1,2,3,4,5
            6,7,8,9,10
            11,12,13,14,15
        */

        Matriz[0,0] = 1; Matriz[0,1] = 2; Matriz[0,2] = 3; Matriz[0,3] = 4; Matriz[0,4] = 5; 

        Matriz[1,0] = 6; Matriz[1,1] = 7; Matriz[1,2] = 8; Matriz[1,3] = 9; Matriz[1,4] = 10;

        Matriz[2,0] = 11; Matriz[2,1] = 12; Matriz[2,2] = 13; Matriz[2,3] = 14; Matriz[2,4] = 15;

        Console.WriteLine(Matriz2[0,1]);

    }
}