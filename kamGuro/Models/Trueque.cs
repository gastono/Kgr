using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kamGuro.Models
{
    public class Trueque
    {
        public int ID { get; set; }
        public int ProductoOfrecidoID { get; set; }
        public bool Activo { get; set; }
        public int? OfertaAceptadaID { get; set; }
        //navigation properties
        public Producto ProductoOfrecido { get; set; }
        public Oferta OfertaAceptada { get; set; }
        
    }
}