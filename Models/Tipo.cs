using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsLC.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public Tipo()
        {

        }

        public Tipo(int id, string nome, int categoriaId, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            CategoriaId = categoriaId;
            Categoria = categoria;
        }
    }
}
