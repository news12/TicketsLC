using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsLC.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCategoria { get; set; }

        [Display(Name ="Titulo Do Ticket")]
        [StringLength(50,ErrorMessage ="Máximo de {1} characteres")]
        [Required(ErrorMessage ="O campo {0} deve ser preenchido.")]
        public string Titulo { get; set; }
        [Display(Name ="Descrição do problema")]
        [Required(ErrorMessage ="O campo {0} deve ser preenchido")]
        [StringLength(500, ErrorMessage = "Máximo de {1} characteres")]
        public string Menssagem { get; set; }
        public int IdDestinatario { get; set; }
    }
}
