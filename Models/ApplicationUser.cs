

using Microsoft.AspNetCore.Identity;

namespace TicketsLC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; } 
        public string Sobrenome { get; set; }
        public string Empresa { get; set; }
        public int Tipo { get; set; }

    }
}
