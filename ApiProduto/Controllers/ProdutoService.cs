using ApiProduto.Context;
using ApiProduto.DTOs;
using ApiProduto.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProduto.Controllers
{
    public class ProdutoService
    {
        private readonly ProdutoContext _context;

        public ProdutoService(ProdutoContext context)
        {
            _context = context;
        }

        // Métodos para manipular produtos (CRUD)
        public async Task<List<Produto>> GetProdutosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetProdutoByIdAsync(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task<Produto> AddProdutoAsync(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> UpdateProdutoAsync(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task DeleteProdutoAsync(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        public IEnumerable<DashboardDTO> GetDashboardData()
        {
            return _context.Produtos
                .GroupBy(p => p.Tipo)
                .Select(g => new DashboardDTO
                {
                    Tipo = g.Key,
                    Quantidade = g.Count(),
                    PrecoMedio = g.Average(p => p.PrecoUnitario)
                })
                .ToList();
        }
    }

}
