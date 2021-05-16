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
            /* ---------------------INSERT---------------------- */

            //Venta venta = new Venta();
            //venta.Fecha = "sabado 31 de enero de 2019";
            //venta.Cliente = "Luis Fernando";

            //Producto producto = new Producto();
            //producto.Nombre = "Xiaomi Mi10 Ultra";
            //producto.Precio = "1200.000";
            //producto.Existencia = "10";
            //db.productos.Add(producto);

            //DetalleVenta detalleVenta = new DetalleVenta();
            //detalleVenta.Cantidad = "1";
            //detalleVenta.Precio = "1200.00";
            //detalleVenta.Venta = venta;
            //detalleVenta.Producto = producto;
            //db.detalleVentas.Add(detalleVenta);
            //Console.ReadKey();

            //db.SaveChanges(); // envia los cambios/datos
            ////Console.WriteLine("el ID despues de guardar {0}", venta.VentaId);
            //Console.ReadKey();



            /* ---------------------SELECT---------------------- */

            //parcialEF db = new parcialEF();
            ////unica venta  con estilo linq
            //Venta venta = new Venta();
            //venta = (from i in db.Ventas where i.VentaId ==3 select i).First();

            //Console.WriteLine("El nombre de el cliente es {0} y id {1}", venta.Cliente,venta.VentaId);
            //Console.ReadKey();



            /* ---------------------PROPIEDADES DE NAVEGACION---------------------- */
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta = db.detalleVentas.Where(x => x.IdDetalleVenta == 3).First();
            Console.WriteLine("Nombre de comprador {0}", detalleVenta.Venta.Cliente);
            Console.WriteLine("Compró el siguiente producto {0}", detalleVenta.Producto.Nombre);
            Console.WriteLine("Con un precio de  {0}", detalleVenta.Producto.Precio);
            Console.ReadKey();

        }
    }
}
