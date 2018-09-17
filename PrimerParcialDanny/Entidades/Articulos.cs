using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialDanny.Entidades
{
    class Articulos
    {
        public int IDVendedor { get; set; }
        public string Nombre { get; set; }
        public  float Sueldo { get; set; }
        public float Retencion { get; set; }
        

        public Articulos()
        {

            IDVendedor = 0;
            Nombre = string.Empty;
            Sueldo = 0;
            Retencion = 0;

        }
    }
}
