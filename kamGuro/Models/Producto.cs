using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kamGuro.Models
{
    public class Producto
    {
        public int ID { get; set; }       
        public string Description { get; set; }
        public int? OfrecidoID { get; set; }
        public int UserID { get; set; }
        public bool Activo { get; set; }
        //navigation properties
        public User User { get; set; }
        public Oferta Ofrecido { get; set; }
    }
}