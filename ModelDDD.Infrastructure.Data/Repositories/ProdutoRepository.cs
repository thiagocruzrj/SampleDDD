using System.Collections.Generic;
using System.Linq;
using ModelDDD.Domain.Entities;
using ModelDDD.Domain.Interfaces.Repositories;

namespace ModelDDD.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
