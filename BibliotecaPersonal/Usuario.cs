using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaPersonal
{
    public class Usuario
    {
        public String Nombre { get; set; }
        public String Ap_paterno { get; set; }
        public String Ap_materno { get; set; }
        public String Rut { get; set; }
        public String FechaNacimiento { get; set; }
        public String FechaContrato { get; set; }
        public String AFP { get; set; }
        public String Isapre { get; set; }
        public String Nacionalidad { get; set; }
        public int Sueldo_bru { get; set; }
        public int Sueldo_liq { get; set; }
        public int Edad { get; set; }
        public String cod_trabajador{ get; set; }

        public void CalcularEdad(DateTime nacimiento)
        {
            Edad = DateTime.Now.Year - nacimiento.Year;
        }

        public void CodigoTrab()
        {
            cod_trabajador = "TRAB-" + Nacionalidad + "-" + cod_trabajador;
        }
    }
}
