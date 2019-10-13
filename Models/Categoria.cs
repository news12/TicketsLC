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
        public int IdTipo { get; set; }
        public Tipo Tipo { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, int nome, int descricao, DateTime data, int idTipo, Tipo tipo)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Data = data;
            IdTipo = idTipo;
            Tipo = tipo;
        }
    }
}
