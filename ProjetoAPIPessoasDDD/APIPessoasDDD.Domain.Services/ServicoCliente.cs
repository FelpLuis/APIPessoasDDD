using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Domain.Services
{
    public class ServicoCliente : ServicoID<Cliente>, IServicoCliente
    {
        private readonly IServicoCliente IServicoCliente;

        public ServicoCliente(IServicoCliente iServicoCliente) :base(iServicoCliente)
        {
            this.IServicoCliente = iServicoCliente;
        }
    }
}
