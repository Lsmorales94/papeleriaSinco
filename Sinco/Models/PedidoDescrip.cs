using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinco.Models
{
    public class PedidoDescrip
    {
        [Key]
        public int id { get; set; } 
        public int idUsuario { get; set; }
        public DateTime fecha { get; set; }
        public string concepto { get; set; }

    }
}