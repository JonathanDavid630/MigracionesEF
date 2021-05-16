namespace ParcialEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DetalleVentas", "Cantidad", c => c.String());
            AlterColumn("dbo.Ventas", "Fecha", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ventas", "Fecha", c => c.String(maxLength: 250));
            AlterColumn("dbo.DetalleVentas", "Cantidad", c => c.String(maxLength: 250));
        }
    }
}
