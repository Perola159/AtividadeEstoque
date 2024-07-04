using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstoque
{
    public class cotacao
    {
       public void CalcularCotacaoDolar()
        {
            Console.WriteLine("Qual o valor em dólar que você deseja cotar?");
            double dolar=double.Parse(Console.ReadLine());
            double cotacao = dolar * 5;
            Console.WriteLine($"O valor convertido é de: {cotacao}");
        }
        
    }
}
