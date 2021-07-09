using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    class APIservice : Datos
    {
        public APIservice(int numero) : base(numero) { }

        public override void Entrar()
        {
            Console.WriteLine($"Entrada de Datos APIService");
        }
    }
}
