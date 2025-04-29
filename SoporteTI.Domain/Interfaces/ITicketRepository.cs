using SoporteTI.Domain.Entities;

namespace SoporteTI.Domain.Interfaces
{
    public interface ITicketRepository
    {
        Task<Tb_Ticket> GetTicketByFolioAsync(string Tk_Folio);
        Task<IEnumerable<Tb_Ticket>> GetAllTicketAsync();
        Task<string> GetLastTicketFolio();
        Task CrearTicketAsync(Tb_Ticket ticket);
        Task UpdateTicketAsync(Tb_Ticket ticket);
        Task DeleteTicketAsync(Tb_Ticket ticket);
    }
}
