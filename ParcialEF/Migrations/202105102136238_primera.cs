namespace ParcialEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        IdDetalleVenta = c.Int(nullable: false, identity: true),
                        Cantidad = c.String(maxLength: 250),
                        Precio = c.String(),
                        Producto_IdProducto = c.Int(),
                        Venta_VentaId = c.Int(),
                    })
                .PrimaryKey(t => t.IdDetalleVenta)
                .ForeignKey("dbo.Productos", t => t.Producto_IdProducto)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaId)
                .Index(t => t.Producto_IdProducto)
                .Index(t => t.Venta_VentaId);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 250),
                        Precio = c.String(),
                        Existencia = c.String(),
                    })
                .PrimaryKey(t => t.IdProducto);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        Fecha = c.String(maxLength: 250),
                        Cliente = c.String(),
                    })
                .PrimaryKey(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleVentas", "Venta_VentaId", "dbo.Ventas");
            DropForeignKey("dbo.DetalleVentas", "Producto_IdProducto", "dbo.Productos");
            DropIndex("dbo.DetalleVentas", new[] { "Venta_VentaId" });
            DropIndex("dbo.DetalleVentas", new[] { "Producto_IdProducto" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Productos");
            DropTable("dbo.DetalleVentas");
        }
    }
}
