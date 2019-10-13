using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsLC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Descricao { get; set; }
        public DateTime Data{ get; set; }
    }
}
