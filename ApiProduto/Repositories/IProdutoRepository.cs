using ApiProduto.Entities;

namespace ApiProduto.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> GetProdutoById(int id);
        Task<IEnumerable<Produto>> GetAllProdutos();
        Task AddProduto(Produto produto);
        Task UpdateProduto(Produto produto);
        Task DeleteProduto(int id);
    }
}
