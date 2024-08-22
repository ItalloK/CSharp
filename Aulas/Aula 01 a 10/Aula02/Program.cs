using System;

namespace Aula02{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Oiiiii");
            if(args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
            Console.ReadLine();
        }
    }
}