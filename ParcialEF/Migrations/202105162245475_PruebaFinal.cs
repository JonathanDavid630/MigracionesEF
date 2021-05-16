namespace ParcialEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PruebaFinal : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ventas", "Producto_IdProducto", "dbo.Productos");
            DropIndex("dbo.Ventas", new[] { "Producto_IdProducto" });
            DropColumn("dbo.Ventas", "Producto_IdProducto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ventas", "Producto_IdProducto", c => c.Int());
            CreateIndex("dbo.Ventas", "Producto_IdProducto");
            AddForeignKey("dbo.Ventas", "Producto_IdProducto", "dbo.Productos", "IdProducto");
        }
    }
}
