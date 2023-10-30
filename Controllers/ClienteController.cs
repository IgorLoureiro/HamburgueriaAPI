using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Projeto_Hamburgueria.Context;
using Projeto_Hamburgueria.Entidades;

namespace Projeto_Hamburgueria.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly EstabelecimentoContext _context;

        public ClienteController(EstabelecimentoContext context)
        {
            _context = context;
        }
        [HttpPost("CriarCliente")]
        public IActionResult Create(Clientes clientes)
        {
            _context.Add(clientes);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = clientes.Id }, clientes);
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
            {
                return NotFound();
            } else {
                return Ok(cliente);
            }

        }
    }
}