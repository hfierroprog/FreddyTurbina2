using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaBicicletas
{
    public class bicicleta
    {
        public String Modelo{ get; set; }
        public String Marca{ get; set; }
        public int prec_compra{ get; set; }
        public int prec_venta { get; set; }
        public int ganancia { get; set; }
        public int Stock{ get; set; }
        public String Origen{ get; set; }
        public String Activo { get; set; }
        public String Cod_bici{ get; set; }



        public void crearCod()
        {
            Cod_bici = "BIC-" + Modelo + "-" + Marca + "-" + Origen + "-" + prec_venta + "-" + Cod_bici;
        }
    }
}
