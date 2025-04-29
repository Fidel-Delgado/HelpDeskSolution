using Microsoft.EntityFrameworkCore;
using SoporteTI.Domain.Entities;
using SoporteTI.Domain.Interfaces;
using SoporteTI.Infrastructure.Data;

namespace SoporteTI.Infrastructure.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _context;

        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Tb_Ticket> GetTicketByFolioAsync(string Tk_Folio)
        {
            Tb_Ticket ticket = await _context.Tb_Ticket
                .FirstOrDefaultAsync(t => t.Tk_Folio == Tk_Folio);
            return ticket;
        }
        public async Task<IEnumerable<Tb_Ticket>> GetAllTicketAsync()
        {
            return await _context.Tb_Ticket.ToListAsync();
        }
        public async Task<string> GetLastTicketFolio()
        {
            var lastTicket = await _context.Tb_Ticket
                     .OrderByDescending(t => t.Tk_Folio)
                     .FirstOrDefaultAsync();
            int nextFolioNumber = lastTicket == null ? 1 : int.Parse(lastTicket.Tk_Folio) + 1;
            string folio = nextFolioNumber.ToString("D9");
            return folio;

        }
        public async Task CrearTicketAsync(Tb_Ticket ticket)
        {
            await _context.Tb_Ticket.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTicketAsync(Tb_Ticket ticket)
        {
            _context.Tb_Ticket.Update(ticket);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteTicketAsync(Tb_Ticket ticket)
        {
            _context.Tb_Ticket.Remove(ticket);
            await _context.SaveChangesAsync();
        }
    }
}
