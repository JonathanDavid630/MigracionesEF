using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEF
{
    class Program
    {
        static void Main(string[] args)
        {
            parcialEF db = new parcialEF();
            //insertar

            Venta venta = new Venta();
            venta.Fecha = "martes 27 de enero de 2019";
            venta.Cliente = "Pepe Antonio";
            db.Ventas.Add(venta);

            Producto producto = new Producto();
            producto.Nombre = "Samsung Galaxy s20";
            producto.Precio = "900.000";
            producto.Existencia = "12";
            db.productos.Add(producto);

            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.Cantidad = "1";
            detalleVenta.Precio = "900.00";
            detalleVenta.Venta = venta;
            detalleVenta.Producto = producto;
            db.detalleVentas.Add(detalleVenta);
            Console.ReadKey();



            Console.WriteLine("el ID antes de guardar {0}", venta.VentaId);



            db.SaveChanges(); // envia los cambios/datos
            Console.WriteLine("el ID despues de guardar {0}", venta.VentaId);

            //Console.WriteLine("el ID antes de guardar {0}", venta.VentaId);


            // envia los cambios/datos
            //Console.WriteLine("el ID despues de guardar {0}", venta.VentaId);
        }
    }
}
