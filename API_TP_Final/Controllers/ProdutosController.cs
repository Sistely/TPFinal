using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using API_TP_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TP_Final.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProdutosController : Controller
    {
        private readonly TPContext _context;

        public ProdutosController(TPContext context)
        {
            _context = context;
        }
        // GET: api/v1/produtos
        [HttpGet]
        public String Index()
        {
            var produtos = _context.Produtos.Select(pr => new Produto
            {
                Id = pr.Id,
                Nome = pr.Nome,
                Preco = pr.Preco,              
                Status = pr.Status,
                UsuarioCadastro = pr.UsuarioCadastro,
                UsuarioUpdate = pr.UsuarioUpdate
            });
            return JsonConvert.SerializeObject(produtos);
        }

        // GET: api/v1/produtos/5
        [HttpGet("{id}")]
        public async Task<String> Details(int id)
        {
            var produto = await _context.Produtos.Include(usuario => usuario.UsuarioCadastro).Include(usuario => usuario.UsuarioUpdate).FirstOrDefaultAsync(n => n.Id == id);
            return JsonConvert.SerializeObject(produto);
        }

        // POST: api/v1/produtos
        [HttpPost]
        public async Task<IActionResult> Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return Ok(produto);
            }
            return NotFound();
        }

        // PUT: api/v1/produtos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Produto produto)
        {

            if (ModelState.IsValid)
            {
                var prAntigo = await _context.Produtos.FirstOrDefaultAsync(n => n.Id == id);

                prAntigo.Nome = produto.Nome;
                prAntigo.Preco = produto.Preco;
                prAntigo.Status = produto.Status;
                prAntigo.UsuarioCadastro = produto.UsuarioCadastro;
                prAntigo.UsuarioUpdate = produto.UsuarioUpdate;
    
                await _context.SaveChangesAsync();
                return Ok(prAntigo);
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE: api/v1/produtos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var entity = await _context.Produtos.FirstOrDefaultAsync(n => n.Id == id);
            if (entity == null)
                return NotFound();
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
