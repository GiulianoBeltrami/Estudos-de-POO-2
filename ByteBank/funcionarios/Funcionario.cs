using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.funcionarios
{
    class Funcionario
    {
        private int _TipoFuncionario;
        public Funcionario(int TipoFuncionario) 
        {
            TipoFuncionario = _TipoFuncionario;
        }
        //0 = funcionário
        //1 = diretor
        //2 = designer
        //n = ...
        public double GetBonificacao() //retorna a bonificacao de acordo com o tipo de funcionário
        {
            if (_TipoFuncionario == 1)
            {
                return Salario;
            }
            return Salario * 0.10;
        }

        public string Nome { set; get; }
        public string CPF { set; get; }
        public double Salario { set; get; }

    }
}
