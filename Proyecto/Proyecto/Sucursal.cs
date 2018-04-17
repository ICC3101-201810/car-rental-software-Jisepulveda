using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Sucursal
    {
        public string nombre;
        public string Direccion;
        public List<Vehiculo> vehiculo;


        public Sucursal (string miNombre , string miDireccion, List<Vehiculo> miVehiculo)
        {
            nombre = miNombre;
            Direccion = miDireccion;
            vehiculo = miVehiculo;
        }
    }
}
