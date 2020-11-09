using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1._1.funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
            
        }
        public override double GetBonificacao() //retorna a bonificacao
        {
            return Salario + base.GetBonificacao();
        }
    }
}
