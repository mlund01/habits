namespace goodhabits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        GoalId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Question = c.String(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SessionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GoalId);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId);
            
            CreateTable(
                "dbo.UserResponses",
                c => new
                    {
                        UserResponseId = c.Int(nullable: false, identity: true),
                        Answer = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        GoalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserResponseId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.UserResponses");
            DropTable("dbo.Sessions");
            DropTable("dbo.Goals");
        }
    }
}
