namespace MovieRentals.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Hip-Hop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Rap')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'House')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'R&B')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Gospel')");
        }

        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8)");
        }
    }
}
