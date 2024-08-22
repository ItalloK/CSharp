using System;
using System.Collections.Generic;
using Internal;

/* Coleção List pt2 */

class Aula58{
    static void Main(){
        
        List<string> Carros1 = new List<string>();
        Carros1.Add("Golf");
        Carros1.Add("HRV");
        Carros1.Add("Focus");
        Carros1.Add("Argo");
        Carros1.Add("HRV");


        Carros1.Insert(1, "Cruze"); // Posição e Nome.


        //Carros1.Remove("Argo"); // Remove por Nome ( Removeu Argo )
        //Carros1.RemoveAt(0); // Remove por posição ( Removeu Golf )
        //Carros1.RemoveAll(); // Remove Todos

        //Carros1.Reverse(); // Inverte a Lista
        //Carros1.Sort(); // Ordena por ordem alfabetica

        int tamanho=Carros1.Count; // Conta quantos modelos tem
        Console.WriteLine("Tamanho da Lista: {0}", tamanho);

        Carros1.Capacity = 25; // Define a Capacidade da Lista ( dimninuir depois que ja tem elementos pode causar problemas )

        int Capacity = Carros1.Capacity; // Conta quanto de capacidade tem a lista
        Console.WriteLine("Capacidade de armazenamento: {0}", Capacity);

        


        foreach(string c in Carros1){
            Console.WriteLine("Carros1: {0}", c);
        }

        int position = Carros1.LastIndexOf("HRV"); // Pega a posição do Ultimo "HRV"
        Console.WriteLine("Posição: {0}", position);

        


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

        /* A partir daqui começa a parte 2 da Aula */


        


    }
}