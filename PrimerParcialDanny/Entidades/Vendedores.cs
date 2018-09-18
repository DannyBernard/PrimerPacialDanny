using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialDanny.Entidades
{
    class Vendedores
    {
        [Key]
        public int IDVendedor { get; set; }
        public string Nombre { get; set; }
        public  decimal Sueldo { get; set; }
        public decimal Retencion { get; set; }
        public decimal Total { get; set; }
        

        public Vendedores()
        {

            IDVendedor = 0;
            Nombre = string.Empty;
            Sueldo = 0;
            Retencion = 0;
            Total = 0;

        }
    }
}
