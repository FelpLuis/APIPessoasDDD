using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Domain.Services
{
    public class ServicoEndereco : ServicoID<Endereco>, IServicoEndereco
    {
        private readonly IServicoEndereco IServicoEndereco;

        public ServicoEndereco(IServicoEndereco IServicoEndereco) : base(IServicoEndereco)
        {
            this.IServicoEndereco = IServicoEndereco;
        }
    }
}
