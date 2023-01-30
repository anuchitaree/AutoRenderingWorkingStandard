namespace AutoRenderingWorkingStandard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Books", "Author_AuthorId", "public.Authors");
            DropIndex("public.Books", new[] { "Author_AuthorId" });
            CreateTable(
                "public.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("public.Authors");
            DropTable("public.Books");
        }
        
        public override void Down()
        {
            CreateTable(
                "public.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author_AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "public.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            DropTable("public.Accounts");
            CreateIndex("public.Books", "Author_AuthorId");
            AddForeignKey("public.Books", "Author_AuthorId", "public.Authors", "AuthorId");
        }
    }
}
