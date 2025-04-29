using SoporteTI.Application.DTOs;
using SoporteTI.Application.Helpers;
using SoporteTI.Application.Interfaces;
using SoporteTI.Domain.Entities;
using SoporteTI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTI.Application.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _repository;
        public TicketService(ITicketRepository repository)
        {
            _repository = repository;
        }
        public async Task<TicketDto> GetTicketByFolioAsync(string Tk_Folio)
        {
            var ticket = await _repository.GetTicketByFolioAsync(Tk_Folio);
            var ticketDtos = new TicketDto
            {
                Tk_Folio = ticket.Tk_Folio,
                Tk_Title = ticket.Tk_Title,
                Tk_Description = ticket.Tk_Description,
                Tk_Reason = ticket.Tk_Reason,
                Tk_CreatedById = ticket.Tk_CreatedById,
                Tk_AssignedToId = ticket.Tk_AssignedToId,
                Tk_StatusId = ticket.Tk_StatusId,
                Tk_CreatedDate = ticket.Tk_CreatedDate,
                Tk_ImpactId = ticket.Tk_ImpactId,
                Tk_PriorityId = ticket.Tk_PriorityId
            };
            return ticketDtos;
        }
        public async Task<IEnumerable<TicketDto>> GetAllTicketAsync()
        {
            var tickets = await _repository.GetAllTicketAsync();
            var ticketDtos = tickets.Select(ticket => new TicketDto
            {
                Tk_Folio = ticket.Tk_Folio,
                Tk_Title = ticket.Tk_Title,
                Tk_Description = ticket.Tk_Description,
                Tk_Reason = ticket.Tk_Reason,
                Tk_CreatedById = ticket.Tk_CreatedById,
                Tk_AssignedToId = ticket.Tk_AssignedToId,
                Tk_StatusId = ticket.Tk_StatusId,
                Tk_CreatedDate = ticket.Tk_CreatedDate,
                Tk_ImpactId = ticket.Tk_ImpactId,
                Tk_PriorityId = ticket.Tk_PriorityId
            }).ToList();

            return ticketDtos;
        }
        public async Task<string> GetLastTicketFolioAsync()
        {
            return await _repository.GetLastTicketFolio();
        }
        public async Task CrearTicketAsync(TicketDto ticketDto)
        {
            var ticket = new Tb_Ticket
            {
                Tk_Folio = ticketDto.Tk_Folio,
                Tk_Title = ticketDto.Tk_Title,
                Tk_Reason = ticketDto.Tk_Reason,
                Tk_Description = ticketDto.Tk_Description,
                Tk_CreatedById = ticketDto.Tk_CreatedById,
                Tk_AssignedToId = ticketDto.Tk_AssignedToId,
                Tk_CreatedDate = DateTime.Now,
                Tk_StatusId = Convert.ToInt16(EnumDropdownHelper.GetStatusTicketbyId("1").Value),
                Tk_ImpactId = ticketDto.Tk_ImpactId,
                Tk_PriorityId = ticketDto.Tk_PriorityId
            };

            await _repository.CrearTicketAsync(ticket);
        }
        public async Task UpdateTicketAsync(TicketDto ticketDto)
        {
            var ticket = new Tb_Ticket
            {
                Tk_Folio = ticketDto.Tk_Folio,
                Tk_Title = ticketDto.Tk_Title,
                Tk_Reason = ticketDto.Tk_Reason,
                Tk_Description = ticketDto.Tk_Description,
                Tk_CreatedById = ticketDto.Tk_CreatedById,
                Tk_AssignedToId = ticketDto.Tk_AssignedToId,
                Tk_CreatedDate = DateTime.Now,
                Tk_StatusId = ticketDto.Tk_StatusId,
                Tk_ImpactId = ticketDto.Tk_ImpactId,
                Tk_PriorityId = ticketDto.Tk_PriorityId
            };

            await _repository.UpdateTicketAsync(ticket);
        }
        public async Task DeleteTicketAsync(TicketDto ticketDto)
        {
            var ticket = new Tb_Ticket
            {
                Tk_Folio = ticketDto.Tk_Folio,
                Tk_Title = ticketDto.Tk_Title,
                Tk_Reason = ticketDto.Tk_Reason,
                Tk_Description = ticketDto.Tk_Description,
                Tk_CreatedById = ticketDto.Tk_CreatedById,
                Tk_AssignedToId = ticketDto.Tk_AssignedToId,
                Tk_CreatedDate = DateTime.Now,
                Tk_StatusId = ticketDto.Tk_StatusId,
                Tk_ImpactId = ticketDto.Tk_ImpactId,
                Tk_PriorityId = ticketDto.Tk_PriorityId
            };
            await _repository.DeleteTicketAsync(ticket);
        }
    }
}
