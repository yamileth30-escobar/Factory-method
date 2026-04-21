using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracMethod.producto
{
    public class ArchivoVideo : IArchivo
    {
        public void MostrarAccion() => System.Console.WriteLine("Reproduciendo archivo de Video...");
    }
}
