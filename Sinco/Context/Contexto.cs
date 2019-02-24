using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Sinco.Models;

namespace Sinco.Context
{
    public class Contexto: DbContext
    {
        public DbSet<Persona> Personas { set; get; }
        public DbSet<Articulo> Articulos { set; get; }
        public DbSet<PedidoDescrip> Pedidos { set; get; }
        public DbSet<PedidoDetalle> PedidosDetalles { set; get; }
    }
}