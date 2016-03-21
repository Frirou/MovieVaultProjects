namespace MovieVault.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inchallah3ad : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "boxoffice",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            id_Movie = c.Int(),
            //            id_user = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("moviesheet", t => t.id_Movie)
            //    .ForeignKey("personne", t => t.id_user)
            //    .Index(t => t.id_Movie)
            //    .Index(t => t.id_user);

            CreateTable(
                "moviesheet",
                c => new
                    {
                        id_Movie = c.Int(nullable: false, identity: true),
                        dateOfRelasing = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        img = c.Binary(),
                        moviequiz = c.Binary(),
                        moyRate = c.Int(nullable: false),
                        nb_rate = c.Int(nullable: false),
                        rate = c.Int(nullable: false),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                        trailer = c.String(maxLength: 255, storeType: "nvarchar"),
                        type = c.String(maxLength: 255, storeType: "nvarchar"),
                        personne_id = c.Int(),
                    })
                .PrimaryKey(t => t.id_Movie)
                .ForeignKey("personne", t => t.personne_id)
                .Index(t => t.personne_id);
            
            //CreateTable(
            //    "event",
            //    c => new
            //        {
            //            idEvent = c.Int(nullable: false, identity: true),
            //            address = c.String(maxLength: 255, storeType: "nvarchar"),
            //            begin_date = c.DateTime(precision: 0),
            //            blocked = c.Boolean(nullable: false),
            //            end_date = c.DateTime(precision: 0),
            //            img = c.Binary(),
            //            latitude = c.Single(nullable: false),
            //            longitude = c.Single(nullable: false),
            //            moyRate = c.Int(nullable: false),
            //            name = c.String(maxLength: 255, storeType: "nvarchar"),
            //            nbCheckIn = c.Int(nullable: false),
            //            nb_rate = c.Int(nullable: false),
            //            nbrTicket = c.Int(nullable: false),
            //            rate = c.Int(nullable: false),
            //            typeevt = c.String(maxLength: 255, storeType: "nvarchar"),
            //            id_Movie = c.Int(),
            //            personne_id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.idEvent)
            //    .ForeignKey("moviesheet", t => t.id_Movie)
            //    .ForeignKey("personne", t => t.personne_id)
            //    .Index(t => t.id_Movie)
            //    .Index(t => t.personne_id);
            
            //CreateTable(
            //    "personne",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            DTYPE = c.String(nullable: false, maxLength: 31, storeType: "nvarchar"),
            //            adress = c.String(maxLength: 255, storeType: "nvarchar"),
            //            etat_civile = c.String(maxLength: 255, storeType: "nvarchar"),
            //            img = c.Binary(),
            //            login = c.String(maxLength: 255, storeType: "nvarchar"),
            //            mail = c.String(maxLength: 255, storeType: "nvarchar"),
            //            nom = c.String(maxLength: 255, storeType: "nvarchar"),
            //            password = c.String(maxLength: 255, storeType: "nvarchar"),
            //            phone = c.Int(nullable: false),
            //            prenom = c.String(maxLength: 255, storeType: "nvarchar"),
            //            valide = c.Boolean(),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "cinematheater",
            //    c => new
            //        {
            //            id_Theater = c.Int(nullable: false, identity: true),
            //            address = c.String(maxLength: 255, storeType: "nvarchar"),
            //            description = c.String(maxLength: 255, storeType: "nvarchar"),
            //            img = c.Binary(),
            //            latitude = c.Single(nullable: false),
            //            longitude = c.Single(nullable: false),
            //            moyRate = c.Int(nullable: false),
            //            name = c.String(maxLength: 255, storeType: "nvarchar"),
            //            nb_rate = c.Int(nullable: false),
            //            rate = c.Int(nullable: false),
            //            id_admin = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id_Theater)
            //    .ForeignKey("personne", t => t.id_admin)
            //    .Index(t => t.id_admin);
            
            //CreateTable(
            //    "ticket",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            idEvent = c.Int(),
            //            idUser = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("event", t => t.idEvent)
            //    .ForeignKey("personne", t => t.idUser)
            //    .Index(t => t.idEvent)
            //    .Index(t => t.idUser);
            
            //CreateTable(
            //    "moviecrew",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            actors = c.String(maxLength: 255, storeType: "nvarchar"),
            //            directors = c.String(maxLength: 255, storeType: "nvarchar"),
            //            img = c.Binary(),
            //            movieMaker = c.String(maxLength: 255, storeType: "nvarchar"),
            //            personne = c.Binary(),
            //            stars = c.String(maxLength: 255, storeType: "nvarchar"),
            //            id_Movie = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("moviesheet", t => t.id_Movie)
            //    .Index(t => t.id_Movie);
            
            //CreateTable(
            //    "question",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            question = c.String(maxLength: 255, storeType: "nvarchar"),
            //            movquiz_idmovQuiz = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "reponse",
            //    c => new
            //        {
            //            id_rep = c.Int(nullable: false, identity: true),
            //            rep_1 = c.String(maxLength: 255, storeType: "nvarchar"),
            //            rep_2 = c.String(maxLength: 255, storeType: "nvarchar"),
            //            rep_3 = c.String(maxLength: 255, storeType: "nvarchar"),
            //            question_id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id_rep)
            //    .ForeignKey("question", t => t.question_id)
            //    .Index(t => t.question_id);
            
            //CreateTable(
            //    "moviesheet_moviecrew",
            //    c => new
            //        {
            //            crew_id = c.Int(nullable: false),
            //            MovieSheet_id_Movie = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.crew_id, t.MovieSheet_id_Movie })
            //    .ForeignKey("moviecrew", t => t.crew_id, cascadeDelete: true)
            //    .ForeignKey("moviesheet", t => t.MovieSheet_id_Movie, cascadeDelete: true)
            //    .Index(t => t.crew_id)
            //    .Index(t => t.MovieSheet_id_Movie);
            
        }
        
        public override void Down()
        {
            DropForeignKey("reponse", "question_id", "question");
            DropForeignKey("boxoffice", "id_user", "personne");
            DropForeignKey("boxoffice", "id_Movie", "moviesheet");
            DropForeignKey("moviesheet", "personne_id", "personne");
            DropForeignKey("moviesheet_moviecrew", "MovieSheet_id_Movie", "moviesheet");
            DropForeignKey("moviesheet_moviecrew", "crew_id", "moviecrew");
            DropForeignKey("moviecrew", "id_Movie", "moviesheet");
            DropForeignKey("event", "personne_id", "personne");
            DropForeignKey("ticket", "idUser", "personne");
            DropForeignKey("ticket", "idEvent", "event");
            DropForeignKey("cinematheater", "id_admin", "personne");
            DropForeignKey("event", "id_Movie", "moviesheet");
            DropIndex("moviesheet_moviecrew", new[] { "MovieSheet_id_Movie" });
            DropIndex("moviesheet_moviecrew", new[] { "crew_id" });
            DropIndex("reponse", new[] { "question_id" });
            DropIndex("moviecrew", new[] { "id_Movie" });
            DropIndex("ticket", new[] { "idUser" });
            DropIndex("ticket", new[] { "idEvent" });
            DropIndex("cinematheater", new[] { "id_admin" });
            DropIndex("event", new[] { "personne_id" });
            DropIndex("event", new[] { "id_Movie" });
            DropIndex("moviesheet", new[] { "personne_id" });
            DropIndex("boxoffice", new[] { "id_user" });
            DropIndex("boxoffice", new[] { "id_Movie" });
            DropTable("moviesheet_moviecrew");
            DropTable("reponse");
            DropTable("question");
            DropTable("moviecrew");
            DropTable("ticket");
            DropTable("cinematheater");
            DropTable("personne");
            DropTable("event");
            DropTable("moviesheet");
            DropTable("boxoffice");
        }
    }
}
