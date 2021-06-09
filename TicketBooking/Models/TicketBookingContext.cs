﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketBooking.Models
{
    public class TicketBookingContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TicketBookingContext() : base("name=TicketBookingContext")
        {
        }

        public System.Data.Entity.DbSet<TicketBooking.Models.Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<TicketBooking.Models.Booking> Bookings { get; set; }

        public System.Data.Entity.DbSet<TicketBooking.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<TicketBooking.Models.Seats> Seats { get; set; }

        public System.Data.Entity.DbSet<TicketBooking.Models.Show> Shows { get; set; }

        public System.Data.Entity.DbSet<TicketBooking.Models.Theater> Theaters { get; set; }

        public System.Data.Entity.DbSet<TicketBooking.Models.Tickets> Tickets { get; set; }
    }
}
