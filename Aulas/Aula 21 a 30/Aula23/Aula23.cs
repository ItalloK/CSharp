using System;
using Internal;

class Aula23{
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,44},{66,77,88,99,00}};

        Random random=new Random(); // Gera numeros aleatorios.
        for(int i = 0; i<vetor1.Length; i++){
            vetor1[i] = random.Next(50); // se bota só () ele gera aleatorios, se usa (50) é de 0 a 49, ou (0,10) min e max.
        }

        Console.WriteLine("Elementos do vetor 1:");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        Console.WriteLine("BinarySearch");
        int Procurado=33;
        int pos=Array.BinarySearch(vetor1, Procurado);  // Procura o valor de 'procurado' dentro do 'vetor' e retorna o local
        Console.WriteLine("O Valor {0} está na posição {1}", Procurado, pos);
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length); // Copia do vetor 2 para o vetor 1 e a quantidade de elementos
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0); // Copia do vetor 1 para o vetor 3, o 0 é o indice de inicio.
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("GetLongLenght");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor=vetor1.GetLowerBound(0); // Esse 0 é sobre dimensão, se for vetor é sempre 0, se for matriz depende.
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor 1: {0}", MenorIndiceVetor);
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do vetor 1: {0}", MaiorIndiceVetor);
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("GetValue");
        int Valor0=Convert.ToInt32(vetor1.GetValue(3)); // tem que fazer a conversão pois o retorno é objeto
        int Valor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor 1: {0}", Valor0);
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3); //retorna o valor do primeiro numero encontrado ( no caso o 3)
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,3); //retorna o valor do ultimo numero encontrado ( no caso o 3)
        Console.WriteLine("Indice do ultimo valor 3: {0}", indice2);
        Console.WriteLine("-----------------------------------------------");

        Array.Reverse(vetor1); // Inverte a ordem dos valores do vetor
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }


        vetor1.SetValue(99, 0); // seta 99 na posição 0
        for(int i = 0; i<vetor2.Length; i++){
            vetor2.SetValue(0,i); // Agora seta 0 para todas as posições
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }


        Array.Sort(vetor1); // Ordena os valores em ordem crescente
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor 1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 3");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }



    }   
}