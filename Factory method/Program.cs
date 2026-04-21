using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstracMethod.Factory;

namespace AbstracMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArchivoFactory fabrica = new ImagenFactory();
            IArchivo archivo = fabrica.CrearArchivo();
            archivo.MostrarAccion();

            System.Console.ReadKey();
        }
    }
}
