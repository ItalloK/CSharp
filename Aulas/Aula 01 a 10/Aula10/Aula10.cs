using System;
using Internal;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};

    static void Main(){

        DiasSemana ds = (DiasSemana)2; // Ou -> DiasSemana ds = DiasSemana.Domingo;
        int Ds2 = (int)DiasSemana.Sexta;
        Console.WriteLine("O dia é: {0} equivalente ao {1}º dia da semana", ds, Ds2);
        
    }

}