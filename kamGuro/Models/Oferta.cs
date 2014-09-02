using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kamGuro.Models
{
    public class Oferta
    {
        
        public int ID { get; set; }
        public int ItemOfrecidoID { get; set; }
        public int ItemAgenoID { get; set; }
        public string Estado { get; set; }
        public bool Activo { get; set; }
        //Navigation Properties
        public virtual Item ItemOfrecido { get; set; }
        public virtual Item ItemAgeno { get; set; }
    }
}