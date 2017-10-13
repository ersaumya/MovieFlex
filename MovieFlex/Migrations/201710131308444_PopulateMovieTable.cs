namespace MovieFlex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into movies(Name,GenreId,DateAdded,ReleasedDate,NumberInStock)values('Fast and Furious 7',1,01-10-2017,15-05-2015,10)");
            Sql("Insert into movies(Name,GenreId,DateAdded,ReleasedDate,NumberInStock)values('Annabelle',2,01-10-2017,15-05-2017,6)");
            Sql("Insert into movies(Name,GenreId,DateAdded,ReleasedDate,NumberInStock)values('Dog Gone',3,03-10-2017,15-05-2008,12)");
            Sql("Insert into movies(Name,GenreId,DateAdded,ReleasedDate,NumberInStock)values('A Walk to Remember',4,01-10-2017,15-05-2002,10)");
            Sql("Insert into movies(Name,GenreId,DateAdded,ReleasedDate,NumberInStock)values('Mr Bean Holiday',5,01-10-2017,15-05-2007,10)");
        }
        
        public override void Down()
        {
        }
    }
}
