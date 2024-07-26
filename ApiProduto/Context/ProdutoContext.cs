using ApiProduto.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiProduto.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
