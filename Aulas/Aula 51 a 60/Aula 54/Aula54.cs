using System;

/* Namespaces -> Serve apenas de organização, sempre por o nome do namespace antes da classe tipo 'Calc1.Area.Quad();' */

namespace Calc1{
    class Area{
        public static float Quad(float bas, float alt){
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou Altura não podem ser igual a 0"); // Retorna o erro 
            }
            return bas*alt;
        }
    }    
}

namespace Calc2{
    class Area{
        public static float Quad(float bas, float alt){
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou Altura não podem ser igual a 0"); // Retorna o erro 
            }
            return bas*alt;
        }
    }    
}

class Aula54{
    static void Main(){
        float area = 0;
        try{
            area = Calc1.Area.Quad(0F, 5F); // F pq é float ( aqui ele ta chamando do namescape calc1 )
            Console.WriteLine("Area do Quadrado: {0}", area);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim do Processo.");
        }
    }
}