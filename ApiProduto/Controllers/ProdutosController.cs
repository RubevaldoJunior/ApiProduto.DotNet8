using ApiProduto.DTOs;
using ApiProduto.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProduto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            var produtos = await _produtoService.GetProdutosAsync();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _produtoService.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> AddProduto(Produto produto)
        {
            var novoProduto = await _produtoService.AddProdutoAsync(produto);
            return CreatedAtAction(nameof(GetProduto), new { id = novoProduto.Id }, novoProduto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest("ID do produto não corresponde ao ID fornecido na URL.");
            }

            try
            {
                await _produtoService.UpdateProdutoAsync(produto);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ProdutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private async Task<bool> ProdutoExists(int id)
        {
            return await _produtoService.GetProdutoByIdAsync(id) != null;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            await _produtoService.DeleteProdutoAsync(id);
            return NoContent();
        }

        [HttpGet("dashboard")]
        public ActionResult<IEnumerable<DashboardDTO>> GetDashboard()
        {
            return _produtoService.GetDashboardData().ToList();
        }
    }
}
