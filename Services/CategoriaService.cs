using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketsLC.Data;
using TicketsLC.Models;

namespace TicketsLC.Services
{
    public class CategoriaService
    {
        private readonly ApplicationDbContext _context;

        public CategoriaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<Categoria> FindAll()
        {
            return _context.Categoria.OrderBy(b => b.Nome).ToList();
        }
    }
}
