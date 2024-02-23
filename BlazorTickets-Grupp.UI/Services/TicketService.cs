using BlazorTickets_Grupp.Data.DataBase.Models;
using Newtonsoft.Json;

namespace BlazorTickets_Grupp.UI.Services
{
    public class TicketService
{
    public HttpClient client { get; set; } = new()
    {
        BaseAddress = new Uri("https://localhost:7141/api/")
    };

   public async Task<List<TicketModel>> GetAllTickets()
    {
        var response = await client.GetAsync("Tickets");

        if (response.IsSuccessStatusCode)
        {
            string jsonString = await response.Content.ReadAsStringAsync();
            List<TicketModel>? tickets = JsonConvert.DeserializeObject<List<TicketModel>>(jsonString);

            if (tickets != null)
            {
                return tickets;
            }
            throw new JsonException();
        }
        throw new HttpRequestException();


    }
    



}
}
