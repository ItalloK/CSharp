using System;
using Internal;

class Calculadora{

    static void Main(){
        int Valor1, Valor2, Condicao;
        Console.WriteLine("Digite o primeiro Valor: ");
        Valor1  = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo Valor: ");
        Valor2 = int.Parse(Console.ReadLine());
        do{
            Console.WriteLine("Valores digitados: {0} e {1}.", Valor1, Valor2);
            Console.WriteLine("1 - Para Somar.");
            Console.WriteLine("2 - Para Subtrair.");
            Console.WriteLine("3 - Para Divisão.");
            Console.WriteLine("4 - Para Multiplicação.");
            Console.Write("Escolha a opção desejada: ");
            Condicao = int.Parse(Console.ReadLine());
        }while(Condicao > 4 || Condicao < 1);

        switch(Condicao){
            case 1:{
                Console.WriteLine("A soma de {0} + {1} é: {2}", Valor1, Valor2, (Valor1+Valor2));
                break;
            }
            case 2:{
                Console.WriteLine("A subtração de {0} - {1} é: {2}", Valor1, Valor2, (Valor1-Valor2));
                break;
            }
            case 3:{
                if(Valor2 > 0){
                    Console.WriteLine("A divisão de {0} / {1} é: {2}", Valor1, Valor2, (Valor1/Valor2));
                }else{
                    Console.WriteLine("Não é possivel fazer uma divisão por 0.");
                }
                break;
            }
            case 4:{
                Console.WriteLine("A multiplicação de {0} * {1} é: {2}", Valor1, Valor2, (Valor1*Valor2));
                break;
            }
        }
    }
}
