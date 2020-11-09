using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);
            carlos.Nome = "Carlos";
            carlos.CPF = "488.759.236-13";
            carlos.Salario = 1000;
            Console.WriteLine("Bonus : "+ carlos.GetBonificacao());

            Console.ReadLine();
        }
    }
}
