namespace AutoRenderingWorkingStandard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "public.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author_AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("public.Authors", t => t.Author_AuthorId)
                .Index(t => t.Author_AuthorId);
            
            CreateTable(
                "public.WorkingStandards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Partnumber = c.String(nullable: false, maxLength: 100),
                        Destination = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Books", "Author_AuthorId", "public.Authors");
            DropIndex("public.Books", new[] { "Author_AuthorId" });
            DropTable("public.WorkingStandards");
            DropTable("public.Books");
            DropTable("public.Authors");
        }
    }
}
