using System;

namespace Venta.Models
{
    public class Venta   
    {
        public int Id { get; set; }
        
        public date fecha { get; set; } 

        public int iva { get; set; }

        public int descuento { get; set; } 

        public int total { get; set; }      
    }
}
