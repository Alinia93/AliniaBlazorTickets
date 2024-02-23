using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTickets_Grupp.Data.DataBase.Models
{
    public class TicketTag
    {
        public int TicketId { get; set; }
        public TicketModel Ticket { get; set; }
        public int TagId { get; set; }
        public TagModel Tag { get; set; } 
    }
}
