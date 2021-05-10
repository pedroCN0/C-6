using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class ContratoAluguel
    {
        private double valor;
        private int validade;
        private string data;
        private int df;

        public void DefinirAlguel()
        {
            int dia, mes, ano;
            Console.Write("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());
            data = dia + " / " + mes + " / " + ano;
            Console.WriteLine("A data é" + data);
            Console.WriteLine("Por quantos dias voce vai alugar o carro? ");
            validade = int.Parse(Console.ReadLine());
            valor = validade * 100;
            Console.ReadKey();
        }
        public void ExibirAluguel()
        {
            valor = validade * 100;
            Console.WriteLine(data);
            Console.WriteLine("O valor do seu aluguel é: " + valor);
        }
    }
}
