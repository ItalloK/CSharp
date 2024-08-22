using System;
using Internal;

class Aula06{

    static void Main(){
        /*
        int n1, n2, n3;
        n1 = 10; n2 = 20; n3 = 30;
        //Console.WriteLine(n1 + ", " + n2 + ", " + n3); -> Forma esquisita
        // Console.WriteLine("%d, %d, %d", n1, n2, n3); -> Desse jeito não funciona
        Console.WriteLine("\tN1={0}\n\tN2={1}\n\tN2={2}", n1, n2, n3); // Jeito do Video ( \n = Quebra de Linha, \t = Tabulação)
        */

        double Valor_Compra = 5.50;
        double Valor_Venda;
        double Lucro = 0.1;
        string Produto = "Pastel";

        Valor_Venda = Valor_Compra+(Valor_Compra*Lucro);

        Console.WriteLine("Produto.....:{0, 15}", Produto); // O {0, 15} = ( 0 = Indice da variavel e 15 = Espaço entre o texto e a variavel)
        Console.WriteLine("Valor compra.....:{0, 15:c}", Valor_Compra); // O ( :c ) é para adicionar o Cifrão de dinheiro 
        Console.WriteLine("Lucro.....:{0, 15:p}", Lucro); // O ( :p ) é para adicionar o Porcentagem.
        Console.WriteLine("Valor de Venda.....:{0, 15:c}", Valor_Venda);

    }

}