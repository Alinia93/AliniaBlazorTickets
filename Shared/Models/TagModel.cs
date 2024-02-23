using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTickets_Grupp.Data.DataBase.Models;

public class TagModel
{
    public int Id { get; set; }
    public string Name { get; set; } // Exempel: "CSharp", "JavaScript"
    public List<TicketTag> TicketTags { get; set; } = new List<TicketTag>();
}

