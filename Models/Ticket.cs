using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsLC.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="É necessário preencher o campo {0}")]
        [StringLength(50,ErrorMessage ="Tamanho máximo permitido é {1}")]
        [Display(Name ="Titulo do Ticket")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "É necessário preencher o campo {0}")]
        [StringLength(500, ErrorMessage = "Tamanho máximo permitido é {1}")]
        [Display(Name = "Descrição do Ticket")]
        public string Menssage { get; set; }
        public int DestinatarioId { get; set; }
    }
}
