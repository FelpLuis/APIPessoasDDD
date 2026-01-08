using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Domain.Services
{
    public class ServicoContato : ServicoID<Contato>, IServicoContato
    {
        private readonly IServicoContato IServicoContato;

        public ServicoContato(IServicoContato IServicoContato) : base(IServicoContato)
        {
            this.IServicoContato = IServicoContato;
        }
    }
}
