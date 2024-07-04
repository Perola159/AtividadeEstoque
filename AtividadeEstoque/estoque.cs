using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstoque
{
   public class estoque
    {
        public double QntdMaxima { get; set; }
        public double QntdMedia{ get; set; }

        public void estoqueMedio()
        {
            Console.WriteLine("Qual a quantidade Máxima?");
            QntdMaxima=int.Parse(Console.ReadLine());

            double  EstoqueMedio = (QntdMaxima + QntdMedia) / 2;

            Console.WriteLine("Qual a mínima?");
            QntdMedia=int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor total do estoque médio é: {EstoqueMedio} ");
        }
    }
}
