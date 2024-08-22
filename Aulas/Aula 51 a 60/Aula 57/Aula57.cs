using System;
using System.Collections.Generic;
using Internal;

/* Coleção List */

class Aula57{
    static void Main(){
        
        List<string> Carros1 = new List<string>();
        Carros1.Add("Golf");
        Carros1.Add("HRV");
        Carros1.Add("Focus");
        Carros1.Add("Argo");

        foreach(string c in Carros1){
            Console.WriteLine("Carros1: {0}", c);
        }

        //Carros1.Clear(); // Limpa todos os itens.

        if(Carros1.Contains("Gol")){ // Verifica se o "Gol" está na lista
            Console.WriteLine("Está na lista");
        }else{
            Console.WriteLine("Não está na lista");
        }   

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        string[] Carros3 = new string[10];
        Carros1.CopyTo(Carros3, 0); // Copia tudo da lista Carros1 para a Carros3 ( salvamento feito no array a partir de 0 )
        foreach(string c in Carros3){
            Console.WriteLine("Carros3: {0}", c);
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        List<string> Carros2 = new List<string>();
        Carros2.AddRange(Carros1); // Adiciona os itens da Carros 1 em Carros 2
        foreach(string c in Carros2){
            Console.WriteLine("Carros2: {0}", c);
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        string carroprocura = "HRV";
        int pos = 0;
        pos=Carros1.IndexOf(carroprocura); // Procura em qual Index está o ' carroprocura ' ( ele só pega o primeiro achado )
        /* no indexof acima pode ser tambem o nome direto e não uma variavel */
        Console.WriteLine("O carro: {0} está no index: {1}", carroprocura, pos); // se for -1 é pq não achou
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    }
}