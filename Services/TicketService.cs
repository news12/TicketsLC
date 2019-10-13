using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketsLC.Data;
using TicketsLC.Models;

namespace TicketsLC.Services
{
    public class TicketService
    {
        private readonly ApplicationDbContext _context;

        public TicketService(ApplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<Ticket> FindAll()
        {
            return _context.Ticket.OrderBy(b => b.Id).ToList();
        }

    }
}
