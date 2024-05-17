namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nova2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Doctors", name: "Hospital_Id", newName: "hospitalWork_Id");
            RenameIndex(table: "dbo.Doctors", name: "IX_Hospital_Id", newName: "IX_hospitalWork_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Doctors", name: "IX_hospitalWork_Id", newName: "IX_Hospital_Id");
            RenameColumn(table: "dbo.Doctors", name: "hospitalWork_Id", newName: "Hospital_Id");
        }
    }
}
