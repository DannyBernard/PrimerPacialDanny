using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialDanny.Entidades
{
    class Articulos
    {
        public int ID { get; set; }
        public string Descipcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaDeVencimiento { get; set; }

        public Articulos()
        {
            ID = 0;
            Descipcion = string.Empty;
            Precio = 0;
            Cantidad = 0;
            FechaDeVencimiento = DateTime.Now;

        }
    }
}
