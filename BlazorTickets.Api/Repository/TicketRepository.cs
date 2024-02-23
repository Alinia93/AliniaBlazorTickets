using BlazorTickets_Grupp.Data.DataBase.DbContexts;
using BlazorTickets_Grupp.Data.DataBase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorTickets.Api.Repository
{
    public class TicketRepository
    {
     

        private AppDbContext _context;
        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }

        //Hämta alla tickets 

        public async Task<List<TicketModel>> GetAllWithTagsAndResponses()
        {
            return await _context.Tickets.Include(t => t.TicketTags).ThenInclude(tt => tt.Tag).Include(t => t.Responses).ToListAsync();
        }




    }
}
