using APIPessoasDDD.Data;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Infraestructure.Data.Repository
{
    public class RepositoryContato : RepositoryID<Contato>, IServicoContato
    {
        private readonly PessoasDbContext pessoasDbContext;

        public RepositoryContato(PessoasDbContext pessoasDbContext) : base(pessoasDbContext)
        {
            this.pessoasDbContext = pessoasDbContext;
        }
    }
}
