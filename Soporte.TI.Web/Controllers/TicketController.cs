using Microsoft.AspNetCore.Mvc;
using SoporteTI.Application.DTOs;
using SoporteTI.Application.Helpers;
using SoporteTI.Application.Interfaces;
using System.Threading.Tasks;

namespace Soporte.TI.Web.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _ticketService.GetAllTicketAsync());
        }

        public async Task<IActionResult> Create()
        {
            TicketDto ticketDto = new TicketDto() { Tk_Folio = await _ticketService.GetLastTicketFolioAsync()};
            ViewBag.Status = EnumDropdownHelper.GetStatusTicket();
            ViewBag.Impact = EnumDropdownHelper.GetImpactTicket();
            ViewBag.Priority = EnumDropdownHelper.GetPriorityTicket();
            return View(ticketDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TicketDto ticketDto)
        {
            await _ticketService.CrearTicketAsync(ticketDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string Tk_Folio)
        {
            TicketDto ticket = await _ticketService.GetTicketByFolioAsync(Tk_Folio);
            ViewBag.Status = EnumDropdownHelper.GetStatusTicket();
            ViewBag.Impact = EnumDropdownHelper.GetImpactTicket();
            ViewBag.Priority = EnumDropdownHelper.GetPriorityTicket();
            return View(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TicketDto ticketDto)
        {
            await _ticketService.UpdateTicketAsync(ticketDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string Tk_Folio) 
        {
            TicketDto ticket = await _ticketService.GetTicketByFolioAsync(Tk_Folio);
            ViewBag.Status = EnumDropdownHelper.GetStatusTicket();
            ViewBag.Impact = EnumDropdownHelper.GetImpactTicket();
            ViewBag.Priority = EnumDropdownHelper.GetPriorityTicket();
            return View(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(TicketDto ticketDto)
        {
            await _ticketService.DeleteTicketAsync(ticketDto);
            return RedirectToAction("Index");
        }
    }
}
