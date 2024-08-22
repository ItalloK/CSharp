using System;
using System.Collections.Generic;
using Internal; // Adiciona o Dictionary

/* Coleção Dictionary */

class Aula55{
    static void Main(){
        
        Dictionary <int, string> veiculos = new Dictionary<int, string>(); // poderia ser os 2 int ( isso aq cria o dictionary )
        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        veiculos.Remove(20); // Remove do directionary utilizando a Chave

        //veiculos.Clear(); // Limpa o Dictionary
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count); // Conta o tamanho do Dictionary

        int chave = 20;
        if(veiculos.ContainsKey(chave)){ // Verifica se a chave está no Directionary
            Console.WriteLine("A chave {0} está na coleção.", chave);
        }else{
            Console.WriteLine("A chave {0} não está na coleção.", chave);
        }

        veiculos[15] = "Bicicleta"; // Substitui o Valor da chave 15 por "Bicicleta". ( não é mais patinete )

        string valor = "Bicicleta";
        if(veiculos.ContainsValue(valor)){ // Verifica se o valor está no Directionary
            Console.WriteLine("O valor {0} está na coleção.", valor);
        }else{
            Console.WriteLine("O valor {0} não está na coleção.", valor);
        }
        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Key); // Pode ser v.Key para imprimir a key ou v.Value para os valores
        }


        /* Outra versão é: */

        Dictionary <int, string>.ValueCollection valores = veiculos.Values; 
        foreach(string v in valores){
            Console.WriteLine(v); // Aqui ele ler o dictionary e imprime.
        }


    }
}