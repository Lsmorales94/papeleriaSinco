using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinco.Models
{
    public class PedidoDescrip
    {
        public PedidoDescrip()
        {
            detallePedido = new List<PedidoDetalle>();
        }
        [Key]
        public int id { get; set; } 
        public int idUsuario { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fecha { get; set; }
        public string concepto { get; set; }
        public List<PedidoDetalle> detallePedido { get; set; }
    }
}