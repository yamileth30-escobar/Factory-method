using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracMethod.Factory
{
    public abstract class ArchivoFactory
    {
        public abstract IArchivo CrearArchivo();
    }
}
