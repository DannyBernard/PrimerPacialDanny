using PrimerParcialDanny.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimerParcialDanny.DAL
{
    class Contexto: DbContext
    {
        public DbSet<Vendedores> Vendedore { get; set; }

        public Contexto() : base("ConStr")
       {
       }

    }
}
