using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1._1.funcionarios;
using ByteBank1._1.Sistema;

// https://www.alura.com.br/artigos/poo-programacao-orientada-a-objetos
// Classe(planta da casa) -> Objeto(casa) -> Atributos (caracteristicas do objeto)
//                                        -> Métodos (ações do objeto)

namespace ByteBank1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            UsarSistema();

            Console.ReadLine();
        }
        static void UsarSistema()
        {
            SistemaInterno SistemaInterno= new SistemaInterno();
            ParceiroComercial jose = new ParceiroComercial();
            jose.Senha = "abc";

            SistemaInterno.logar(jose, "123");


        }


    }
}
