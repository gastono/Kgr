using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kamGuro.Models
{
    public class Item
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
        public ItemImage Image { get; set; }

    }
}