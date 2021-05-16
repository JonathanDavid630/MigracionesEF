using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParcialEF
{
   
    public class DetalleVenta
    {
        //entity framework notaciones
        [Key]
        public int IdDetalleVenta { get; set; }
     
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        
        public virtual Producto Producto { get; set; }
        
        public virtual Venta Venta { get; set; }
    }


    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; } 
        [MaxLength(250), MinLength(10)]

        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Existencia { get; set; }
    }


    public class Venta
    {
        public int VentaId { get; set; }
      
        public string Fecha { get; set; }
        public string Cliente { get; set; }
    }
}
