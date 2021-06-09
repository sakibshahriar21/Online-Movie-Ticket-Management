using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TicketBooking.Models;

namespace TicketBooking.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class MyContext: DbContext
    {
        public MyContext()
            : base("DefaultConnection")
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        //Your model classes should be added as DbSets
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Seats> Seats { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Theater> Theater { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
       

    }
}