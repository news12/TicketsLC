using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsLC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Tipo> Tipos { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, string nome, string descricao, DateTime data, ICollection<Tipo> tipos)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Data = data;
            Tipos = tipos;
        }
    }
}
