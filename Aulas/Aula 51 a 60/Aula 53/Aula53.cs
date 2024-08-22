using System;
using Internal;

/* Exceções - Try Catch Finally */

class Area{
    public static float Quad(float bas, float alt){
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou Altura não podem ser igual a 0"); // Retorna o erro 
        }
        return bas*alt;
    }
}

class Aula53{
    static void Main(){
        float area = 0;
        try{
            area = Area.Quad(0F, 5F); // F pq é float
            Console.WriteLine("Area do Quadrado: {0}", area);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim do Processo.");
        }

        /*int n1,n2,res;
        res=n1=n2=0;
        n1=10;
        n2=2;
        try{
            res=n1/n2; 
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res); // Não é impresso pois do try vai pro catch ( em caso de erro )
            throw new Exception("ERRO TESTE"); // Gerando Exception
        }catch(Exception e){ // Pega a Exception e salva em ( e )
            Console.WriteLine("ERRO: {0}", e.Message); // Exibe a Mensagem simplificada
        }finally{ // Executa independente do resultado ( não é obrigatório )
            Console.WriteLine("Fim do Processo.");
        }*/
    }
}