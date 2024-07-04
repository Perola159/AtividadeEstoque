using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AtividadeEstoque
{
   public class Pagamento
    {
        public int identificacaoVendedor { get; set; }
        public int CodPeca { get; set; }
        public int ValorTotal { get; set; }
        public double PrecoUnitarioPeca { get; set; }
        public int QntVendida { get; set; }   
        public int PecaValor { get; set; }


        public void IdentVende()
        {
            Console.WriteLine("Qual o ID do vendedor?");
            identificacaoVendedor=int.Parse(Console.ReadLine());

        }

        public void PrecoPeca()
        {
            Console.WriteLine("Qual o preço unitário da peça?");
            PecaValor = int.Parse(Console.ReadLine());
        }
       
        public void QntdVendida()
        {
            Console.WriteLine("Qual a quantidade vendida?");
            QntVendida = int.Parse(Console.ReadLine());
        }

        public void Codpeca()
        {
            Console.WriteLine("Qual o código da Peça");
            CodPeca = int.Parse(Console.ReadLine());
        }

        public void Valortotal()
        {
            Console.WriteLine("E o valor total?");
            ValorTotal = int.Parse(Console.ReadLine());
        }
        public void ComissaoVenda()
        {
            double Comissao = PecaValor * 5;

            Console.WriteLine($"O id do vendedor é: {identificacaoVendedor}");
            Console.WriteLine($"O preço unitário dela é: {PecaValor}");
            Console.WriteLine($"A quantidade vendida foi {QntVendida}");
            Console.WriteLine($"O valor total foi: {ValorTotal}");
            Console.WriteLine($"O valor total da comissão é {Comissao}");
            
        }
    }
}
