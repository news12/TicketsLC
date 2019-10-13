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
        public Tipo IdTipo { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, int nome, int descricao, DateTime data, Tipo idTipo)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Data = data;
            IdTipo = idTipo;
        }
    }
}
