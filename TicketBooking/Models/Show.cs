using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketBooking.Models
{
    public class Show
    {
        public int Id { get; set; }
        public DateTime sDate { get; set; }
        public DateTime eDate { get; set; }
    }
}