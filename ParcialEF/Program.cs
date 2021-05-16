using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            parcialEF db = new parcialEF();
            ////insertar

            //Venta venta = new Venta();
            //venta.Fecha = "martes 27 de enero de 2019";
            //venta.Cliente = "Pepe Antonio";
            //db.Ventas.Add(venta);

            //Producto producto = new Producto();
            //producto.Nombre = "Samsung Galaxy s20";
            //producto.Precio = "900.000";
            //producto.Existencia = "12";
            //db.productos.Add(producto);

            //DetalleVenta detalleVenta = new DetalleVenta();
            //detalleVenta.Cantidad = "1";
            //detalleVenta.Precio = "900.00";
            //detalleVenta.Venta = venta;
            //detalleVenta.Producto = producto;
            //db.detalleVentas.Add(detalleVenta);
            //Console.ReadKey();

            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta = db.detalleVentas.Where(x => x.IdDetalleVenta == 3).First();
            Console.WriteLine("Nombre de comprador {0}", detalleVenta.Venta.Cliente);
            Console.WriteLine("Compró el siguiente producto {0}", detalleVenta.Producto.Nombre);
            Console.WriteLine("Con un precio de  {0}", detalleVenta.Producto.Precio);
            Console.ReadKey();

        }
    }
}
