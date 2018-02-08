namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Hangover', 5, 2/8/2018, 2/8/2018, 10)");
            Sql("INSERT INTO movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard', 1, 2/8/2018, 2/8/2018, 10)");
            Sql("INSERT INTO movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Terminator', 1, 2/8/2018, 2/8/2018, 10)");
            Sql("INSERT INTO movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Toy Story', 3, 2/8/2018, 2/8/2018, 10)");
            Sql("INSERT INTO movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Titanic', 4, 2/8/2018, 2/8/2018, 10)");
            Sql("INSERT INTO movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Zootopia', 3, 2/8/2018, 2/8/2018, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
