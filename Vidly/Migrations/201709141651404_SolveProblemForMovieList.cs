namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SolveProblemForMovieList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Movies", "ReleaseDateTime");
            DropColumn("dbo.Movies", "DataAddeDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "DataAddeDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
