namespace OneOff.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoftDeleteProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "IsArtist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "IsArtist", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "IsDeleted");
        }
    }
}
