using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Empresa : Cliente
    {
        string Nombre;
        string Autorizacion;
        public Empresa (string miNombre , string miAutorizacion)
        {
            this.Nombre = miNombre;
            this.Autorizacion = miAutorizacion;
        }
    }
}
