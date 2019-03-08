using ModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModelDDD.Application.Interface
{
    public interface IClienteAppService: IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
