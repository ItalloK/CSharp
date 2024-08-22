using System;
using Internal;

public class Consultorio{
    static void Main(){
        DateTime Agora = DateTime.Now; // Define Agora como Date
        Console.WriteLine("Horario local: {0}\n\n",Agora.ToString()); // Exibe Data e Hora

        string SenhaMedico = "MED123";
        string SenhaDigitada;

        do{
            Console.Write("Digite sua senha: ");
            SenhaDigitada = Console.ReadLine();
            if(SenhaDigitada != SenhaMedico){
                Console.WriteLine("Senha Incorreta.");
            }else{
                Console.WriteLine("Login Efetuado");
            }
        }while(SenhaDigitada != SenhaMedico);

        Console.Write("Digite o nome do paciente: ");
        string NomePaciente = Console.ReadLine();
        Console.Write("Digite a sala de atendimento: ");
        int SalaAtendimento = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Nome do paciente: {0}", NomePaciente);
        Console.WriteLine("Sala: {0}", SalaAtendimento);
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    }
}
    