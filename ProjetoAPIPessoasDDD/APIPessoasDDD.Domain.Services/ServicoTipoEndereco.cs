using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Domain.Services
{
    public class ServicoTipoEndereco : ServicoID<TipoEndereco>, IServicoTipoEndereco
    {
        private readonly IServicoTipoEndereco IServicoTipoEndereco;

        public ServicoTipoEndereco(IServicoTipoEndereco IServicoTipoEndereco) : base(IServicoTipoEndereco)
        {
            this.IServicoTipoEndereco = IServicoTipoEndereco;
        }
    }
}
