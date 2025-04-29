using SoporteTI.Application.DTOs;
using SoporteTI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTI.Application.Interfaces
{
    public interface ITicketService
    {
        Task<TicketDto> GetTicketByFolioAsync(string Tk_Folio);
        Task<IEnumerable<TicketDto>> GetAllTicketAsync();
        Task<string> GetLastTicketFolioAsync();
        Task CrearTicketAsync(TicketDto ticketDto);
        Task UpdateTicketAsync(TicketDto ticketDto);
        Task DeleteTicketAsync(TicketDto ticketDto);
    }
}
