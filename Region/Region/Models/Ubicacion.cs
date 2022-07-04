using System;
using System.Collections.Generic;
using System.Text;

namespace Region.Models
{
   public  class Ubicacion
    {
        public string zonah2 { get { return $"ZonaHoraria { zonahoraria}"; } }
        public string area2 { get { return $"Area { area}"; } }

        public double latitud { get; set; }
        public double longitud { get; set; }
        public string area { get; set; }
        public string zonahoraria { get; set; }
        public String nombre { get; set; }
        public String pcapital { get; set; }
        public string poblacion { get; set; }
    }
}
