using System;
using System.Collections.Generic;
using Internal;

/* Coleção Queue (Fila) */

class Aula59{
    static void Main(){
        /* Pode ser usado o nome dessa array de String para iniciar na queue */
        //string[] Vs={"Carro", "Moto", "Navio", "Avião"};
        //Queue<string>Veiculos=new Queue<string>(Vs); -> o Vs ali é o nome do Array

        Queue<string>Veiculos=new Queue<string>();

        Veiculos.Enqueue("Carro");
        Veiculos.Enqueue("Moto");
        Veiculos.Enqueue("Navio");
        Veiculos.Enqueue("Avião"); // Adiciona no final da fila

        string v = "Avião";
        if(Veiculos.Contains(v)){ // Procura o ' avião ' na fila ( Metodo Contains )
            Console.WriteLine("Veiculo {0} encontrado.", v);
        }else{
            Console.WriteLine("Veiculo: {0} não está na fila.", v);
        }

        //Veiculos.Clear(); // Limpa a Fila
        //Console.WriteLine("Primeiro Veiculo: {0}", Veiculos.Dequeue()); // Mostra o primeiro elemento e remove o elemento.
        //Console.WriteLine("Primeiro Veiculo: {0}", Veiculos.Peek()); // Mostra o primeiro elemento e não remove o elemento.

        /*foreach(string veic in Veiculos){ // Ler e exibe todos os veiculos da Fila sem remover
           Console.WriteLine("Veiculo: {0}", veic);
        }*/

        //Console.WriteLine("Veiculo: {0}", Veiculos[2]); // Não é possivel usar index no tipo Queue

        Console.WriteLine("Quantidade de elementos na fila: {0}", Veiculos.Count); // Mostra o tamanho da lista

        /* Para resetar a fila ou usando comando clear ou dequeue no loop */

        while(Veiculos.Count > 0){
            Console.WriteLine(Veiculos.Dequeue()); // Limpando a fila
        }

        Console.WriteLine("Quantidade de elementos na fila: {0}", Veiculos.Count);


    }
}