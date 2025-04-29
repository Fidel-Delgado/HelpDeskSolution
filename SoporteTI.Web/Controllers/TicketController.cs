using Microsoft.AspNetCore.Mvc;
using SoporteTI.Application.DTOs;
using SoporteTI.Application.Interfaces;

namespace SoporteTI.Web.Controllers
{
    public class TicketController : Controller
    {

        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(TicketDto ticketDto)
        {
            await _ticketService.CrearTicketAsync(ticketDto);
            return RedirectToAction("Index");
        }
    }
}
