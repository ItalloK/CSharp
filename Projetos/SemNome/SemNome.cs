using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Internal;

public class SemNome{

    static string[] Nomes = new string[5]{"NULL","NULL","NULL","NULL","NULL"};
    static string[] CPFS = new string[5]{"NULL","NULL","NULL","NULL","NULL"};
    static void Main(){
        //Console.Clear();
        DateTime Agora = DateTime.Now; // Define Agora como Date
        Console.WriteLine("Horario local: {0}",Agora.ToString()); // Exibe Data e Hora
        int Opcao;
        do{
            Console.WriteLine("1 - Cadastro.");
            Console.WriteLine("2 - Listar Cadastros.");
            Console.WriteLine("3 - Procurar por CPF.");
            Console.WriteLine("4 - Deletar Cadastro.");
            Console.WriteLine("5 - Encerrar Programa.");
            Console.Write("Digite a opção desejada: ");
            Opcao = int.Parse(Console.ReadLine());
        }while(Opcao < 1 || Opcao > 5);
        switch(Opcao){
            case 1:{
                int Procura = Array.IndexOf(Nomes, "NULL");
                if(Procura == -1){
                    Console.WriteLine("Maximo de nomes ja cadastrados.");
                    Main();
                }else{
                    Cadastro();
                }
                break;
            }
            case 2:{
                ListarCadastros();
                break;
            }
            case 3:{
                ProcurarPessoa();
                break;
            }
            case 4:{
                RemoverPessoas();
                break;
            }
            case 5:{
                Console.Clear();
                Console.WriteLine("Encerrando Programa.");
                Environment.Exit(0);
                break;
            }
        }
    }

    static void Cadastro(){ 
        Console.Clear();
        int Indice = Array.IndexOf(Nomes, "NULL");
        if(Indice != -1){
            Console.WriteLine("~~~~ CADASTRO ~~~~");
            Console.Write("Digite o nome a ser cadastrado: ");
            Nomes[Indice] = Console.ReadLine();
            int CpfsCad;
            do{
                Console.Write("Agora digite o CPF de '{0}' : ", Nomes[Indice]);
                string RecebeCPF;
                RecebeCPF = Console.ReadLine();
                CpfsCad = Array.IndexOf(CPFS, RecebeCPF);
                if(CpfsCad < 0){
                    CPFS[Indice] = RecebeCPF;
                }else if(CpfsCad >= 0){
                    Console.WriteLine("ERRO, esse CPF ja está cadastrado.");
                }
                if(RecebeCPF.Length < 11 || RecebeCPF.Length > 11){
                    Console.WriteLine("Erro, você digitou um CPF inválido.");
                }               
            }while(CPFS[Indice].Length < 11 || CpfsCad >= 0);
            Console.Clear();
            Console.WriteLine("Nome: '{0}', CPF: '{1}', cadastrado com sucesso.\n\n", Nomes[Indice], CPFS[Indice]);
            Main();
        }else{
            Console.WriteLine("Não tem mais espaços para serem cadastrados.");
            Main();
        }        
    }
    static void ListarCadastros(){
        Console.Clear();
        Console.WriteLine("Nomes Cadastrados: ");
        for(int i = 0; i<Nomes.Length; i++){
            Console.WriteLine("Nome: '{0}' \tCPF: '{1}'", Nomes[i], CPFS[i]);
        }        
        char Cond;
        Console.WriteLine("Deseja voltar para o menu principal? [S/N]");
        Cond = char.Parse(Console.ReadLine());
        if(Cond == 'S' || Cond == 's'){
            Console.WriteLine("Voltando para menu principal.");
            Main();
        }else{
            Console.Clear();
            Console.WriteLine("Encerrando programa.");
            Environment.Exit(0);
        }
    }
    static void ProcurarPessoa(){
        Console.Clear();
        string CPF;
        Console.Write("Digite o CPF que deseja procurar: ");
        CPF = Console.ReadLine();
        int Indice = Array.IndexOf(CPFS, CPF);
        if(Indice != -1){
            Console.WriteLine("\nO CPF '{0}' foi encontrado no indice {1} o nome é: '{2}'", CPF, Indice, Nomes[Indice]);
        }else{
            Console.WriteLine("\nO CPF não foi encontrado.");
        }
        char Cond;
        Console.WriteLine("Deseja voltar para o menu principal? [S/N]");
        Cond = char.Parse(Console.ReadLine());
        if(Cond == 'S' || Cond == 's'){
            Console.WriteLine("Voltando para menu principal.");
            Main();
        }else{
            Console.Clear();
            Console.WriteLine("Encerrando programa.");
            Environment.Exit(0);
        }
    }

    static void RemoverPessoas(){
        Console.Clear();
        string CPF;
        Console.WriteLine("Digite o CPF da pessoa que deseja deletar: ");
        CPF = Console.ReadLine();
        int Indice = Array.IndexOf(CPFS, CPF);
        if(Indice != -1){
            Console.WriteLine("\nO CPF procurado é: '{0}', Nome:'{1}'... Deseja remover? [S/N]",CPF, Nomes[Indice]);
            char Cond;
            Cond = char.Parse(Console.ReadLine());
            if(Cond == 's' || Cond == 'S'){
                Console.WriteLine("Nome: '{0}' CPF: '{1}' Deletados com sucesso.", Nomes[Indice], CPFS[Indice]);
                Nomes[Indice] = "NULL";
                CPFS[Indice] = "NULL";
                Console.WriteLine("Voltando para o menu principal...");
                Main();
            }else if(Cond == 'n' || Cond == 'N'){
                Console.WriteLine("Esta pessoa não foi deletada... Voltando para menu principal.");
                Main();
            }else{
                Console.WriteLine("Condição digitada incorretamente... Encerrando programa.");
                Environment.Exit(0);
            }
        }else{
            Console.WriteLine("CPF não encontrado... Deseja tentar novamente? [S/N]");
            char Cond2;
            Cond2 = char.Parse(Console.ReadLine());
            if(Cond2 == 's' || Cond2 == 'S'){
                RemoverPessoas();
            }else{
                Console.WriteLine("Voltando para o menu principal...");
            }
        }
        
    }

}