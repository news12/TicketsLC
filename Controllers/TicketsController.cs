using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketsLC.Controllers.Exceptions;
using TicketsLC.Data;
using TicketsLC.Models;

namespace TicketsLC.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Index com metodo get usando o async
        public async Task<IActionResult> Index()
        {
            //retorna uma view com uma lista de tickets
            return View(await _context.Tickets.ToListAsync());
        }

        // Detalhes com metodo get usando o async
        public async Task<IActionResult> Details(int? id)
        {
            // se não for passado um id
            if (id == null)
            {
                //retorna uma view padrão de não encontrado
                return NotFound();
            }
            //instancia um ticket pelo primeiro id 
            var tickets = await _context.Tickets
                .FirstOrDefaultAsync(m => m.Id == id);
            //id não encontrado
            if (tickets == null)
            {
                //retorna uma view padrão de não encontrado
                return NotFound();
            }
            //tudo certo retorna a view com os detalhes do ticket
            return View(tickets);
        }

        // Criar ticket com o metodo get
        public IActionResult Create()
        {
            return View();
        }

        // Metodo post
        [HttpPost]
        //Proteção
        [ValidateAntiForgeryToken]
        //cria um obj do tipo ticket utilizando Bind
        public async Task<IActionResult> Create([Bind("Id,IdUsuario,IdCategoria,Titulo,Menssagem,IdDestinatario")] Tickets tickets)
        {
            //se o status do model for valido
            if (ModelState.IsValid)
            {
                //adiciona o ticket
                _context.Add(tickets);
                //salva o ticket no banco
                await _context.SaveChangesAsync();
               //redireciona para a pagina index do ticket
                return RedirectToAction(nameof(Index));
            }
            //status do model não valido retorna a view
            return View(tickets);
        }

        // Edite usando metodo get
        public async Task<IActionResult> Edit(int? id)
        {
            // se não foi informado um id
            if (id == null)
            {
                //retorna uma pagina de erro padrão
                return NotFound();
            }
            //instancia um ticket pegando o id passado
            var tickets = await _context.Tickets.FindAsync(id);
            //se o id informado não for valido
            if (tickets == null)
            {
                //retorna uma pagina de erro padrão
                return NotFound();
            }
            //Tudo Certo retorna a view com os dados do tickect
            return View(tickets);
        }

        // Metodo Post
        [HttpPost]
        //Proteção 
        [ValidateAntiForgeryToken]
        //cria um obj do tipo ticket utilizando Bind
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdUsuario,IdCategoria,Titulo,Menssagem,IdDestinatario")] Tickets tickets)
        {
            //id passado é diferente de um id de tickets
            if (id != tickets.Id)
            {
                //retorna pagina de erro padrão
                return NotFound();
            }
            // se o model é valido
            if (ModelState.IsValid)
            {
                //iniciamos um try para captura de possiveis erro
                try
                {
                    //atualiza o ticket
                    _context.Update(tickets);
                    //salva o ticket no banco
                    await _context.SaveChangesAsync();
                }
                //passa para o catch erro especifico de update 
                catch (DbUpdateConcurrencyException e)
                {
                    //id to tickets não existe
                    if (!TicketsExists(tickets.Id))
                    {
                        //pagina de erro padrão
                        return NotFound();
                    }
                    //tratamento do erro
                    else
                    {
                        throw new PersonalException(e.Message);
                    }
                }
                //redireciona para a pagina index
                return RedirectToAction(nameof(Index));
            }
            //não é um model valido retorna a view
            return View(tickets);
        }

        // Delete com metodo Get
        public async Task<IActionResult> Delete(int? id)
        {
            //Não foi informado um id
            if (id == null)
            {
                // retorna uma pagina de erro
                return NotFound();
            }

            //instancia um obj ticket com o id informado
            var tickets = await _context.Tickets
                .FirstOrDefaultAsync(m => m.Id == id);
            //id não encontrado
            if (tickets == null)
            {
                //retorna uma pagina de erro
                return NotFound();
            }
            //tudo certo retorna a view com o ticket a ser deletado
            return View(tickets);
        }

        //Metodo Post
        [HttpPost, ActionName("Delete")]
        //Proteção
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //instancia um ticket com o id informado
            var tickets = await _context.Tickets.FindAsync(id);
            //deleta o ticket
            _context.Tickets.Remove(tickets);
            //salva a deleção no banco
            await _context.SaveChangesAsync();
            //redireciona para a pagina index
            return RedirectToAction(nameof(Index));
        }

        private bool TicketsExists(int id)
        {
            //se o tickert existe retorna o ticket referente ao id informado
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
