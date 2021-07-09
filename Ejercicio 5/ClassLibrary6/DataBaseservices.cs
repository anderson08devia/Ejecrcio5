using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    public class DataBaseservices : Datos
    {
        public DataBaseservices(int numero) : base(numero) { }

        public override void Entrar()
        {
            Console.WriteLine($"Entrada de Datos DataBaseservices");
        }
    }
}
