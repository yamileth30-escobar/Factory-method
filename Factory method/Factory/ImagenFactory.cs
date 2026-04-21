using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstracMethod.Factory;
using AbstracMethod.producto;

namespace AbstracMethod
{
    public class ImagenFactory : ArchivoFactory
    {
        public override IArchivo CrearArchivo() => new ArchivoImagen();
    }
}
