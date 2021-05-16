using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEF
{
    public class parcialEF:DbContext
    {
        //todas las entidades que formaran parte de la base de datos 
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> detalleVentas { get; set; }
        public DbSet<Producto> productos { get; set; }

    }
}
