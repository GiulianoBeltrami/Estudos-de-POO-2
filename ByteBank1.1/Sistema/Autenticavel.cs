using ByteBank1._1.funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1._1.Sistema
{
   public interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
