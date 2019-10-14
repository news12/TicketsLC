using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TicketsLC.Controllers
{
    public class TiposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}