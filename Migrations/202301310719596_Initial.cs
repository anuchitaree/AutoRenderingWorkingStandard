namespace AutoRenderingWorkingStandard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.WorkingStandards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScannerText = c.String(nullable: false, maxLength: 100),
                        Partnumber = c.String(nullable: false, maxLength: 20),
                        Destination = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("public.WorkingStandards");
            DropTable("public.Accounts");
        }
    }
}
