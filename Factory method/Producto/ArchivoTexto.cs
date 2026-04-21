using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracMethod.producto
{
    public class ArchivoTexto : IArchivo
    {
        public void MostrarAccion() => System.Console.WriteLine("Abriendo archivo de Texto...");
    }
}