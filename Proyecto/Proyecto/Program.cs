using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a AUTTO");
            Console.WriteLine("\nEl lugar donde pudes crear tu agencia de arriendo de vehiculos.");
            List<Sucursales> TodasSucursales = new List<Sucursales>();
            while (true)
            {
                string nSucursal;
                string nCalle;
                string comuna;
                string numero;
                
                Sucursales NuevaSucursal;
                NuevaSucursal = new Sucursales();

                Console.WriteLine("Porfavor ingrese el nombre de la nueva sucursal:"); nSucursal = Console.ReadLine();
                NuevaSucursal.nombreSucursal = nSucursal;
                Console.WriteLine("Porfavor ingrese el nombre de la calle donde se ubica la sucursal: "); nCalle = Console.ReadLine();
                NuevaSucursal.nombreCalle = nCalle;
                Console.WriteLine("Porfavor ingrese el nombre de la comuna en la que se encuentra la sucursal: "); comuna = Console.ReadLine();
                NuevaSucursal.nombreComuna = comuna;
                Console.WriteLine("Porfavor ingrese el numero donde se encuentra la sucursal: "); numero = Console.ReadLine();
                NuevaSucursal.numeroSucursal = numero;

                foreach (Sucursales a in TodasSucursales)
                {  
                    if (a.nombreSucursal == nSucursal)
                    {
                        Console.WriteLine("Esta Sucursal ya existe");
                    }
                }
                
                TodasSucursales.Add(NuevaSucursal);

            }
        }
    }
}
