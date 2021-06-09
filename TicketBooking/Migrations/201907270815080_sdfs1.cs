namespace TicketBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdfs1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bdate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CName = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        email = c.String(unicode: false),
                        phoneNo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        seateName = c.String(unicode: false),
                        NoOFSeat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        sDate = c.DateTime(nullable: false, precision: 0),
                        eDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Theaters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TName = c.String(unicode: false),
                        Location = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeatNo = c.String(unicode: false),
                        HallNo = c.String(unicode: false),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
            DropTable("dbo.Theaters");
            DropTable("dbo.Shows");
            DropTable("dbo.Seats");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
