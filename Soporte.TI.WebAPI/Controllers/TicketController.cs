using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using SoporteTI.Application.DTOs;
using SoporteTI.Application.Helpers;
using SoporteTI.Application.Interfaces;

namespace Soporte.TI.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tickets = await _ticketService.GetAllTicketAsync();
            return Ok(tickets);
        }

        [HttpGet("{folio}")]
        public async Task<IActionResult> GetByFolio(string folio)
        {
            var ticket = await _ticketService.GetTicketByFolioAsync(folio);
            return Ok(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TicketDto ticketDto)
        {
            await _ticketService.CrearTicketAsync(ticketDto);
            return Ok(new { message = "Ticket creado correctamente" });
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TicketDto ticketDto)
        {
            await _ticketService.UpdateTicketAsync(ticketDto);
            return Ok(new { message = "Ticket actualizado correctamente" });
        }

        [HttpDelete("{folio}")]
        public async Task<IActionResult> Delete(string folio)
        {
            var ticket = await _ticketService.GetTicketByFolioAsync(folio);
            await _ticketService.DeleteTicketAsync(ticket);
            return Ok(new { message = "Ticket eliminado" });
        }
    }

}
