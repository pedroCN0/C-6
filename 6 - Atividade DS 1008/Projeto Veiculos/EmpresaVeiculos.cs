using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class EmpresaVeiculos
    {
        private string Nome;
        private string Endereço;
        private int CNPJ;

        public void RegistraEmpresa()
        {
            Console.WriteLine("Digite o nome da empresa contratada:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço da empresa contratada:");
            Endereço = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ da empresa contratada:");
            CNPJ = int.Parse(Console.ReadLine());
        }
        public void ExibirEmpresa()
        {
            Console.WriteLine("Nome da empresa contratada: " + Nome);
            Console.WriteLine("Endereço da empresa contratada: " + Endereço);
            Console.WriteLine("CNPJ: " + CNPJ);
        }
    }
}
