using ModelDDD.Domain.Entities;
using ModelDDD.Domain.Interfaces.Repositories;

namespace ModelDDD.Infrastructure.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
