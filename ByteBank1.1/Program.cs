using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1._1.funcionarios;

// https://www.alura.com.br/artigos/poo-programacao-orientada-a-objetos
// Classe(planta da casa) -> Objeto(casa) -> Atributos (caracteristicas do objeto)
//                                        -> Métodos (ações do objeto)

namespace ByteBank1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador =new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("488.453.567-20");
            carlos.Nome = "Carlos";
            carlos.Salario = 1000;
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("Bônus: " +carlos.GetBonificacao() );
            Console.WriteLine("Salário: " + carlos.Salario);

            Diretor roberta = new Diretor("123.321.542-90");
            roberta.Nome = "Roberta";
            roberta.Salario = 10000;
            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Bônus: " + roberta.GetBonificacao() );

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);
            Console.WriteLine("Bonificação total: "+ gerenciador.GetBonificacaoTotal());

            Console.WriteLine(Funcionario.NumeroFuncionarios);
            Console.ReadLine();
        }
    }
}
