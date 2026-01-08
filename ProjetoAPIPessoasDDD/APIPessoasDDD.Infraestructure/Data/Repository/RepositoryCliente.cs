using APIPessoasDDD.Data;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Infraestructure.Data.Repository
{

    public class RepositoryCliente : RepositoryID<Cliente>, IServicoCliente
    {
        private readonly PessoasDbContext pessoasDbContext;

        public RepositoryCliente(PessoasDbContext pessoasDbContext) : base(pessoasDbContext)
        {
            this.pessoasDbContext = pessoasDbContext;
        }
    }
}

