using APIPessoasDDD.Data;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Infraestructure.Data.Repository
{
    public class RepositoryTipoContato : RepositoryID<TipoContato>, IServicoTipoContato
    {
        private readonly PessoasDbContext pessoasDbContext;

        public RepositoryTipoContato(PessoasDbContext pessoasDbContext) : base(pessoasDbContext)
        {
            this.pessoasDbContext = pessoasDbContext;
        }
    }
}
