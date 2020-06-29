namespace ThisIsFantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedArsenal : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Ainsley Maitland-Niles', 7792, 'Maitland-Niles A.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Alexandre Lacazette', 7797, 'Lacazette A.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Bernd Leno', 3174, 'Leno B.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Bukayo Saka', 99813, 'Saka B.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Calum Chambers', 7787, 'Chambers C.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Dani Ceballos', 68, 'Ceballos D.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('David Luiz', 7805, 'Luiz D.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Emile Smith-Rowe', 85570, 'Smith-Rowe E.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Emiliano Martínez', 3141, 'Martínez E.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Folarin Balogun', 131040, 'Balogun F.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Granit Xhaka', 3477, 'Xhaka G.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Héctor Bellerín', 7783, 'Bellerin H.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Joe Willock', 7798, 'Willock J.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Kieran Tierney', 15615, 'Tierney K.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Konstantinos Mavropanos', 7789, 'Mavropanos K.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Lucas Torreira', 2260, 'Torreira L.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Martinelli', 61450, ', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Matt Macey', 7779, 'Macey M.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Mattéo Guendouzi', 600, 'Guendouzi M.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Mesut Özil', 3180, 'Ozil M.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Nicolas Pépé', 8412, 'Pepe N.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Pierre-Emerick Aubameyang', 7801, 'Aubameyang P.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Reiss Nelson', 7799, 'Nelson R.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Rob Holding', 7784, 'Holding R.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Robbie Burton', 131039, 'Burton R.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Sead Kolašinac', 7786, 'Kolasinac S.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Shkodran Mustafi', 7785, 'Mustafi S.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Sokratis Papastathopoulos', 137, 'Papastathopoulos S.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Tolaji Bola', 131038, 'Bola T.', 0, 0)");
            //Sql("INSERT INTO dbo.PlayerStats  (Name, PlayerId, ApiName, Goals, OwnGoals) Values ('Unai Emery', 11616, 'Emery U.', 0, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
