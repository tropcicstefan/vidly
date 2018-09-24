namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Western')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romance')");

        }

        public override void Down()
        {
        }
    }
}
