using System;
using System.Collections.Generic;
using Internal;

/* Coleção LinkedList / Lista duplamente encadeada */

class Aula56{
    static void Main(){
        
        LinkedList <string> transp =  new LinkedList<string>(); // transp é o Nome da Lista

        transp.AddFirst("Carro"); // Sempre adiciona o elemento no inicio, então o ultimo será o primeiro.
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta"); // Sempre adiciona o elemento no fim, então o ultimo será o ultimo.

        LinkedListNode<string>no; // Cria o nó para definir o AddAfter e AddBefore
        no = transp.FindLast("Navio"); // Pega o Ultimo "Navio" 
        transp.AddAfter(no,"Patinete"); // Adiciona "Patinete" após "Navio"

        no = transp.FindLast("Carro"); // Pega o Ultimo "Carro" 
        transp.AddBefore(no,"Patins"); // Adiciona "Patins" antes de "Carro"


        //transp.Clear(); // -> Limpa tudo

        if(transp.Find("Carro")==null){ // ' transp.Find("Carro"); 'Faz a Pesquisa ( retorno possivel é null )
            Console.WriteLine("Não Encontrado.");
        }else{
            Console.WriteLine("Elemento Encontrado.");
        } 


        //transp.Remove("Navio"); // Remove um item
 
        transp.RemoveFirst(); // remove o primeiro item
        transp.RemoveLast(); // remove o ultimo item

        /* Metodos do LinkedNode */

        no = transp.FindLast("Navio").Next; // para o proximo ( depois de navio )
        no = transp.FindLast("Navio").Previous; // para o anterior  ( antes de navio )
        no = transp.FindLast("Navio").Value; // retorna o proprio valor do no Apontado.

        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}", t);
        }




    }
}