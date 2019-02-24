using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinco.Models
{
    public class Articulo
    {
        [Key]
        public int codigo { get; set; }
        public string nombre { get; set; }
    }
}