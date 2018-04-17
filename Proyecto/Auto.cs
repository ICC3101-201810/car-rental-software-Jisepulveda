using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Auto : Vehiculo
    {
        
        public string tipo { get; set; }
        public string Patente;
        public string Marca;
        public int rueda;
        public string motor;
        public string consumo;
        public int cantidad;
        public string licencia;
        public Auto(string miTipo, string miPatente, string miMarca, int miRueda, string miMotor, string miConsumo, int miCantidad, string miLicencia)
        {
            tipo = miTipo;
            Patente = miPatente;
            Marca = miMarca;
            rueda = miRueda;
            motor = miMotor;
            consumo = miConsumo;
            cantidad = miCantidad;
            licencia = miLicencia;
        }
    }
        

}
