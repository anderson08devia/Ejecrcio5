using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    public abstract class Datos : Conexion
    {
        public Datos(int numero) { }

        public abstract void Entrar();
        
    }
}
