using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketsLC.Services;

namespace TicketsLC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly CategoriaService _categoriaservice;

        public CategoriasController(CategoriaService categoriaservice)
        {
            _categoriaservice = categoriaservice;
        }
        public IActionResult Index()
        {
           
        var resultado = _categoriaservice.BuscarPorId(1);
            return View(resultado);
        }
    }
}