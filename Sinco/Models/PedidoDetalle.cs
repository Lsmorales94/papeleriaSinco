using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinco.Models
{
    public class PedidoDetalle
    {
        [Key]
        public int id { set; get; }
        public int idPedido { set; get; }
        public int idArticulo { set; get; }
        public int cantidad { set; get; }
        public bool importado { set; get; }

    }
}