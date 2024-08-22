using System;
using Internal;

class Aula21{
    static void Main(){
        int Tentativas = 0;
        string Senha = "123";
        string Senha_Digitada;
        do{
            Console.Clear();
            Console.Write("Digite a senha: ");
            Senha_Digitada = Console.ReadLine();
            Tentativas++;
        }while(Senha_Digitada != Senha);
        Console.Clear();
        Console.WriteLine("Senha Correta, Tentativas: {0}", Tentativas);
    }
}