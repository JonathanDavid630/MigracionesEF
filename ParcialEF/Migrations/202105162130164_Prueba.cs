namespace ParcialEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetalleVentas", "Venta_VentaId", c => c.Int());
            CreateIndex("dbo.DetalleVentas", "Venta_VentaId");
            AddForeignKey("dbo.DetalleVentas", "Venta_VentaId", "dbo.Ventas", "VentaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleVentas", "Venta_VentaId", "dbo.Ventas");
            DropIndex("dbo.DetalleVentas", new[] { "Venta_VentaId" });
            DropColumn("dbo.DetalleVentas", "Venta_VentaId");
        }
    }
}
