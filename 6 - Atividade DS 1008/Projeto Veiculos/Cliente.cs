using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculos
{
    class Cliente
    {
        private string Nome;
        private int Idade;
        private int CPF;
        private string Sobrenome;

        public void RegistraPessoa()
        {
            Console.WriteLine("Digite o nome do contratante: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do contratante: ");
            Sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a idade do contratante: ");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CPF do contratante: ");
            CPF = int.Parse(Console.ReadLine());
        }

        public void ExibirCliente()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Sobrenome: " + Sobrenome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("CPF: " + CPF);
        }
    }
}
