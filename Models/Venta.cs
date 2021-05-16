using System;
using System.Threading.Tasks;


namespace Venta.Models
{
    public class Venta   
    {
        public int Id { get; set; }
        
        public DateTime fecha { get; set; }
        
        public int iva { get; set; }

        public int descuento { get; set; } 

        public int total { get; set; }      
    }
}
