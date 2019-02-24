using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sinco.Models
{
    public class Join
    {
        public PedidoDescrip PedidoDescrip { get; set; }
        public PedidoDetalle PedidoDetalle { get; set; }
        public Articulo Articulo { get; set; }
        public Persona Persona { get; set; }
    }
}