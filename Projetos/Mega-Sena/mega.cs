using System;
using System.Collections.Generic;
public class mega{
    public static void Main(string[] args){
        int[,] matriz = new int[,]
        {
            {10, 27, 40, 46, 49, 58}, 
            {2, 10, 34, 37, 43, 50},  
            {3, 4, 29, 36, 45, 55},   
            {14, 32, 33, 36, 41, 52}, 
            {20, 30, 36, 38, 47, 53}, 
            {1, 5, 11, 16, 20, 56},   
            {2, 18, 31, 42, 51, 56},  
            {5, 11, 22, 24, 51, 53},  
            {3, 6, 10, 17, 34, 37},   
            {5, 10, 12, 18, 25, 33},  
            {3, 35, 38, 40, 57, 58},  
            {17, 20, 22, 35, 41, 42}, 
            {12, 15, 23, 32, 33, 46}, 
            {4, 5, 10, 34, 58, 59},   
            {21, 24, 33, 41, 48, 56}  
        };

        Random random = new Random();
        for(int i = 0; i<6; i++){
            int linhas = matriz.GetLength(0);  
            int colunas = matriz.GetLength(1); 
            int linhaAleatoria = random.Next(0, linhas);  
            int colunaAleatoria = random.Next(0, colunas);  
            int numeroAleatorio = matriz[linhaAleatoria, colunaAleatoria];
            Console.WriteLine("Número aleatório da matriz: {0}", numeroAleatorio);
        }
    }    
}