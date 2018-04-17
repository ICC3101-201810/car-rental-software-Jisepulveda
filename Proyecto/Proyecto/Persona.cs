using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Persona : Cliente
    {
        string Rut;
        string Nombre;
        string Apellido;
        string Licencia;
        string FechaNacimiento;
        public Persona (string miRut , string miNombre , string miApellido , string miLicencia, string miFechaNacimiento)
        {
            this.Rut=miRut;
            this.Nombre = miNombre;
            this.Apellido = miApellido;
            this.Licencia = miLicencia;
            this.FechaNacimiento=miFechaNacimiento;
        }

        public string[] ObtenerLicencia()
        {
            
            string[] Licencias = Licencia.Split('-');
            return Licencias;
        }

        public int calcularEdad()
        {
            DateTime FechaCliente = Convert.ToDateTime(FechaNacimiento);
            DateTime Hoy = DateTime.Today;

            DateTime Edad = (Hoy - FechaCliente);
            return Edad.Year;
        }
       
    }
}
