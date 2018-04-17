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
            Console.WriteLine("Bienvenido a Arriendo Vehiculos");
            Console.WriteLine("1-Crear nueva sucursal");
            Console.WriteLine("2-Arrendar un Vehiculo");
            Console.WriteLine("3-Recibir un Vehiculo");
            Console.WriteLine("4-Salir");
            Console.WriteLine("\nIngrese la opcion de la acccion a realizar:"); string Opcion = Console.ReadLine();
            List<Sucursal> Sucursales = new List<Sucursal>();
            
            if (Opcion=="1")
            {
                List<Vehiculo> vehiculosSucursal = new List<Vehiculo>();
                string nombreSucursal = Console.ReadLine();
                string direccionSucursal = Console.ReadLine();
                Console.WriteLine("1-Si");
                Console.WriteLine("2-No");
                Console.WriteLine("Desea ingresar vehiculos a la sucursal: "); string Ingresar = Console.ReadLine();
                if (Ingresar == "1")
                {
                    
                    while (true)
                    {
                        Console.WriteLine("1-Automovil");
                        Console.WriteLine("2-Motocicleta");
                        Console.WriteLine("3-Camion");
                        Console.WriteLine("4-Bus");
                        Console.WriteLine("5-Acuatico");
                        Console.WriteLine("6-Maquinaria Pesada");
                        Console.WriteLine("7-Volver a pantalla inicial");

                        Console.WriteLine("Que tipo de vehiculo desea ingresar: "); string tipo = Console.ReadLine();

                        if (tipo == "1")
                        {
                            string tipoVehiculo = Console.ReadLine();
                            string patenteVehiculo = Console.ReadLine();
                            string marcaVehiculo = Console.ReadLine();
                            string rVehiculo = Console.ReadLine();
                            int ruedaVehiculo = int.Parse(rVehiculo);
                            string motorVehiculo = Console.ReadLine();
                            string consumoVehiculo = Console.ReadLine();
                            string cVehiculo = Console.ReadLine();
                            int cantidadVehiculo = int.Parse(cVehiculo);
                            string licenciaVehiculo = Console.ReadLine();

                            Auto auto = new Auto(tipoVehiculo, patenteVehiculo, marcaVehiculo, ruedaVehiculo, motorVehiculo, consumoVehiculo, cantidadVehiculo, licenciaVehiculo);

                            vehiculosSucursal.Add(auto);

                            continue;
                        }
                        
                        
                        //auto, acuático, moto, camión, bus y maquinaria pesada(tractor, retro-excavadora, etc).
                        
                    }
                    
                }
                Sucursal sucursal = new Sucursal(nombreSucursal, direccionSucursal, vehiculosSucursal);
            }
            List<Arriendo> Arriendos = new List<Arriendo>();
            List<Cliente> Clientes = new List<Cliente>();

            if (Opcion=="2")
            {
                Console.WriteLine("Comencemos con el arriendo");
                Console.WriteLine("¿Quien desea realizar el arriendo?");
                Console.WriteLine("1-Persona");
                Console.WriteLine("2-Empresa");
                Console.WriteLine("Ingrese la opcion deseada"); string OpcionCliente = Console.ReadLine();

                if (OpcionCliente=="1")
                {
                    //Creamos Cliente

                    Console.WriteLine("Porfavor ingrese los siguientes datos del cliente en minuscula siempre");
                    Console.WriteLine("Rut (sin puntos ni guion"); string rutCliente = Console.ReadLine();
                    Console.WriteLine("Nombre");string nombreCliente = Console.ReadLine();
                    Console.WriteLine("Apellido");string apellidoCliente = Console.ReadLine();
                    Console.WriteLine("Licencia (Si posee mas de una ingreselas separadas por un guion"); string licenciaCliente = Console.ReadLine();
                    Console.WriteLine("Fecha de Nacimiento (DD/MM/AAAA)"); string fechanacimientoCliente = Console.ReadLine();
                    
                    Persona persona= new Persona(rutCliente , nombreCliente,apellidoCliente,licenciaCliente,fechanacimientoCliente);
                    int EdadCliente = persona.calcularEdad;
                    if (EdadCliente<18)
                    {
                        Console.WriteLine("El Cliente es demasiado joven para realizar un arriendo de vehiculo");
                        
                    }

                    Clientes.Add(persona);

                    //Arriendo de Vehiculo

                }

            }               
            Console.ReadKey();
        }
    }
}
