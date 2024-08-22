using System;

struct Usuario{
    public string Nome;
    public int Idade;
    public string Email;
}
class Program{
    static void Main(){
        Usuario[] US1 = new Usuario[3];
        for(int i = 0; i<US1.Length; i++){
            Console.WriteLine("Digite o nome do Usuario: ");
            US1[i].Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do Usuário: ");
            US1[i].Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email do Usuario: ");
            US1[i].Email = Console.ReadLine();
        }
        for(int i = 0; i<US1.Length; i++){
            Console.WriteLine("ID[{0}] -> Nome: '{1}' Idade: '{2}' Email: '{3}'", i+1, US1[i].Nome, US1[i].Idade, US1[i].Email);
        }
    }
}