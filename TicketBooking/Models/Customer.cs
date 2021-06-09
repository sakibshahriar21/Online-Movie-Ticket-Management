using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketBooking.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CName{get;set;}
        public string Password { get; set; }
        public string email { get; set; }
        public string phoneNo { get; set; }
    }
}