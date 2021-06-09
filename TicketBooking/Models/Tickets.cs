using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketBooking.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string SeatNo { get; set; }
        public string HallNo { get; set; }
        public int price { get; set; }

    }
}