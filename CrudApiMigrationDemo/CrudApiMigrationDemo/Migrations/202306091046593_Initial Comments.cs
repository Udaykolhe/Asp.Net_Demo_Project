namespace CrudApiMigrationDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Details = c.String(),
                        State = c.String(),
                        County = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Code = c.String(),
                        AddressId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId_Id)
                .Index(t => t.AddressId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "AddressId_Id", "dbo.Addresses");
            DropIndex("dbo.Employees", new[] { "AddressId_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Addresses");
        }
    }
}
