using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstoqueDolarPagamneto
{
  public class Operacoes
  {
        public int adicao { get; set; }
        public int escolhanum1 { get; set; }
        public int escolhanum2 { get; set; }

        public int subtracao { get; set; }
        public int multiplicacao { get; set; }
        public int divisao { get; set; }

        public int GetEscolhanum2()
        {
            return escolhanum2;
        }

        public void Adicao()
        {
            int escolhanum1 = 0;
            int escolhanum2 = 0;
            int Resultado = 0;
            
            Console.WriteLine("Digite um Número inteiro válido que deseja somar:");
            escolhanum1= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro válido que deseja somar: ");
            escolhanum2 = int.Parse(Console.ReadLine());

            Resultado = escolhanum1 + escolhanum2;
                Console.WriteLine($"A soma dos resultados é: {Resultado}");
        }

        public void Subtracao()
        {
            int escolhanum1 = 0;
            int escolhanum2 = 0;
            int Resultado = 0;

            Console.WriteLine("Digite um Número inteiro válido que deseja subtrair:");
            escolhanum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro válido que deseja subtrair: ");
            escolhanum2 = int.Parse(Console.ReadLine());

            Resultado = escolhanum1 - escolhanum2;
            Console.WriteLine($"A subtração dos resultados é: {Resultado}");
        }

        public void Multiplicacao()
        {
            int escolhanum1 = 0;
            int escolhanum2 = 0;
            int Resultado = 0;

            Console.WriteLine("Digite um Número inteiro válido que deseja Multiplicar:");
            escolhanum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro válido que deseja  Multiplicar: ");
            escolhanum2 = int.Parse(Console.ReadLine());

            Resultado = escolhanum1 * escolhanum2;
            Console.WriteLine($"A subtração dos resultados é: {Resultado}");
        }


        public void Divisao()
        {
            int escolhanum1 = 0;
            int escolhanum2 = 0;
            int Resultado = 0;

            Console.WriteLine("Digite um Número inteiro válido que deseja Dividir:");
            escolhanum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro válido que deseja Dividir: ");
            escolhanum2 = int.Parse(Console.ReadLine());

            Resultado = escolhanum1 / escolhanum2;
            Console.WriteLine($"A subtração dos resultados é: {Resultado}");
        }
  }
}
       
  

