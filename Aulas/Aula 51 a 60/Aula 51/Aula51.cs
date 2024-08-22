using System;

/* Passagem de Argumentos */

class Aula51{
    static void Main(string[] args){
        int res = 0;
        if(args.Length > 0){
            Console.WriteLine("Qntd de Argumentos: {0}", args.Length);
            for(int i = 0; i < args.Length; i++){
                Console.WriteLine("Argumento {0} -> {1}", i, args[i]);
                res += Int32.Parse(args[i]);
            }
            Console.WriteLine("A soma dos args é: {0}", res);
        }else{
            Console.WriteLine("Não foram passados argumentos...");
        }
    }
}