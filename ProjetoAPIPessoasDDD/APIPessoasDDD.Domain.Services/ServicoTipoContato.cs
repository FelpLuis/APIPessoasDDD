using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Domain.Services
{
    public class ServicoTipoContato: ServicoID<TipoContato>, IServicoTipoContato
    {
        private readonly IServicoTipoContato IServicoTipoContato;

        public ServicoTipoContato(IServicoTipoContato IServicoTipoContato) : base(IServicoTipoContato)
        {
            this.IServicoTipoContato = IServicoTipoContato;
        }
    }
}
