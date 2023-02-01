namespace AutoRenderingWorkingStandard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Accounts", "UserID", c => c.String(nullable: false, maxLength: 20));
            AddColumn("public.Accounts", "HashPassword", c => c.String(nullable: false, maxLength: 80));
            DropColumn("public.Accounts", "User");
            DropColumn("public.Accounts", "Password");
        }
        
        public override void Down()
        {
            AddColumn("public.Accounts", "Password", c => c.String(nullable: false, maxLength: 30));
            AddColumn("public.Accounts", "User", c => c.String(nullable: false, maxLength: 20));
            DropColumn("public.Accounts", "HashPassword");
            DropColumn("public.Accounts", "UserID");
        }
    }
}
