using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsLC.Controllers.Exceptions
{
    public class PersonalException:ApplicationException
    {
        public PersonalException (string message) : base(message)
        {
          //personalizar erros aqui
        }
    }
}
