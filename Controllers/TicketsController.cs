using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketsLC.Services;

namespace TicketsLC.Controllers
{
    public class TicketsController : Controller
    {
        private readonly TicketService _ticketService;

        public TicketsController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public IActionResult Index()
        {
            var Tickets = _ticketService.FindAll();
            return View(Tickets);
        }

    }
}