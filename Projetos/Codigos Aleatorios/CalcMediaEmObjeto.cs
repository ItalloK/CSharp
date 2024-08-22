using System;
using System.Collections.Generic;
using System.Threading;
using Internal;

class Aluno{
    public string Nome = "";
    public int Idade = 0 ;
    public float[] Notas = new float[4];
    public float Media;
}

class Program{
    public static void Main(){
        Aluno[] A = new Aluno[2];
        var sum = 0f;
        for(int i = 0; i<A.Length; i++){
            A[i] = new Aluno();
            Console.WriteLine("Digite o Nome do {0}º Aluno: ", i+1);
            A[i].Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do {0}º Aluno: ", i+1);
            A[i].Idade = int.Parse(Console.ReadLine());
            for(int j = 0; j<4; j++){
                Console.WriteLine("Digite a {0}º nota do {1}º Aluno: ", j+1, i+1);
                A[i].Notas[j] = float.Parse(Console.ReadLine());
                sum += A[i].Notas[j];
            }
            A[i].Media = sum/4;
            sum = 0f;
        }


        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        for(int i = 0; i<2; i++){
            Console.WriteLine("Aluno: {0}", i+1);
            Console.WriteLine("Nome: {0}, Idade: {1},Nota 1: {2},Nota 2: {3},Nota 3: {4},Nota 4: {5}, Media: {6}", 
                A[i].Nome, A[i].Idade, A[i].Notas[0],A[i].Notas[1],A[i].Notas[2],A[i].Notas[3], A[i].Media);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}