using APIPessoasDDD.Data;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Infraestructure.Data.Repository
{
        public class RepositoryTipoCliente : RepositoryID<TipoCliente>, IServicoTipoCliente
        {
            private readonly PessoasDbContext pessoasDbContext;

            public RepositoryTipoCliente(PessoasDbContext pessoasDbContext) : base(pessoasDbContext)
            {
                this.pessoasDbContext = pessoasDbContext;
            }
        }
}
