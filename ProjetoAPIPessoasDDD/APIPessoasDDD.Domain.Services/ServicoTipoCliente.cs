using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Domain.Services
{
    public class ServicoTipoCliente : ServicoID<TipoCliente>, IServicoTipoCliente
    {
        private readonly IServicoTipoCliente IServicoTipoCliente;

        public ServicoTipoCliente(IServicoTipoCliente IServicoTipoCliente) : base(IServicoTipoCliente)
        {
            this.IServicoTipoCliente = IServicoTipoCliente;
        }
    }
}
