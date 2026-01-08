using APIPessoasDDD.Data;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Infraestructure.Data.Repository
{
    public class RepositoryTipoEndereco : RepositoryID<TipoEndereco>, IServicoTipoEndereco
    {
        private readonly PessoasDbContext pessoasDbContext;

        public RepositoryTipoEndereco(PessoasDbContext pessoasDbContext) : base(pessoasDbContext)
        {
            this.pessoasDbContext = pessoasDbContext;
        }
    }
}
