using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketsLC.Data;
using TicketsLC.Models;

namespace TicketsLC.Services
{
    public class TipoService
    {
        private readonly ApplicationDbContext _context;

        public TipoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Tipo> FindAll()
        {
            return _context.Tipo.OrderBy(b => b.Nome).ToList();
        }


    }
}
