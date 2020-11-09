using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1._1.funcionarios
{
    public class Funcionario
    {
        public static int NumeroFuncionarios { get; private set; }
        public Funcionario(string cpf)
        {
            this.CPF = cpf;
            NumeroFuncionarios++;
        }
        
        public virtual double GetBonificacao() //retorna a bonificacao
        {
            return Salario * 0.10;
        }

        public double AumentoSalario(int porcentagem_aumento)
        {
            return this.Salario += porcentagem_aumento * this.Salario; 
        }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

    }
}
