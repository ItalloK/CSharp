using System;
using Internal;

/* Try Catch Finally */

class Aula52{
    static void Main(){
        /*int n1,n2,res;
        res=n1=n2=0;
        n1=10;
        n2=0;
        try{
            res=n1/n2; 
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res); // Não é impresso pois do try vai pro catch ( em caso de erro )
        }catch{
            Console.WriteLine("Erro");
        }*/
        int n1,n2,res;
        res=n1=n2=0;
        n1=10;
        n2=0;
        try{
            res=n1/n2; 
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res); // Não é impresso pois do try vai pro catch ( em caso de erro )
        }catch(Exception e){ // Pega a Exception e salva em ( e )
            Console.WriteLine("ERRO: {0}", e.Message); // Exibe a Mensagem simplificada
        }
    }
}