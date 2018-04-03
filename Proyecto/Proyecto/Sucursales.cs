using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Sucursales
    {
        public string nombreCalle;
        public string numeroSucursal;
        public string nombreComuna;
        public string nombreSucursal;

        //public void Sucursal(int Serie, string nombre, string calle, string comuna, int numero)
        //{
          
            //nombreSucursal = nombre;
            //nombreCalle = calle;
            //nombreComuna = comuna;
            //numeroSucursal = numero;
        //}

        public void DireccionSucursal(Sucursales TodasSucursales)
        {
            Console.WriteLine("La direccion de la sucursal es {0} numero {1} en la comuna de {2}", nombreCalle, numeroSucursal, nombreComuna);
        }

    }
}
