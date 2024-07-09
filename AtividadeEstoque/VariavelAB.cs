using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstoqueDolarPagamneto
{
    public class VariavelAB
    {
        public int VarA { get; set; }
        public int VarB { get; set; }

        public void AtribuindoValorVariavel()
        {
            Console.WriteLine("Digite um valor inteiro A:");
            VarA = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite outro valor inteiro B:");
            VarB = int.Parse(Console.ReadLine());
        }

        public void TrocaValor()
        {
            int VarAaux = VarA;
            int VarBaux = VarB;

            VarA = VarBaux;
            VarB = VarAaux;

            Console.WriteLine($"O valor de A é: {VarA}");
            Console.WriteLine($"O valor de B é: {VarB}");
        }


        public void Modulo()
        {
            Console.WriteLine();
            VarA = int.Parse(Console.ReadLine());


            if(VarA >= 0 )
            {
                VarA = VarA;
                Console.WriteLine("O Valor da variavel é: " + VarA);
            }else if (VarA < 0)
            {
                VarA = VarA * (-1);
                Console.WriteLine("O módulo do valor é" + VarA);
            }
        }
    }
}
