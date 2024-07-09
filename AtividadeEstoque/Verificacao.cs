using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstoqueDolarPagamneto
{
    public class Verificacao
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        


        public void lerNumero()
        {
            Console.WriteLine("Digite um número inteiro:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro:");
            num2 = int.Parse(Console.ReadLine());
        }

        public void verificacao()
        {
            int REsultado = 0;

            if (num1 > num2)
            {
                REsultado = num1 % num2;    
            }
            else
            {
                REsultado = num2 % num1;
            }

            if(REsultado ==0)
            {
                Console.WriteLine($"Os números {num1} e {num2} são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos.");
            }
        }
    }
}
