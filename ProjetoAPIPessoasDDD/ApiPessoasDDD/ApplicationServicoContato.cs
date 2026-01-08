using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Interfaces.Mapper;
using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;

namespace APIPessoasDDD.Application
{
    public class ApplicationServicoContato : IApplicationServicoContato
    {
        private readonly IServicoContato servicoContato;
        private readonly IMapperContato mapperContato;
        public ApplicationServicoContato(IServicoContato servicoContato, IMapperContato mapperContato)
        {
            this.servicoContato = servicoContato;
            this.mapperContato = mapperContato;
        }
        public void Add(TransferContato transferContato)
        {
            var contato = mapperContato.MapperTransferToEntity(transferContato);
            servicoContato.Add(contato);
        }

        public TransferContato GetById(int id)
        {
            var contato = servicoContato.GetById(id);
            return mapperContato.MapperEntityToTransfer(contato);
        }

        public IEnumerable<TransferContato> GetAll()
        {
            var contato = servicoContato.GetAll();
            return mapperContato.MapperListTransferContato(contato);
        }

        public void Remove(TransferContato transferContato)
        {
            var contato = mapperContato.MapperTransferToEntity(transferContato);
            servicoContato.Remove(contato);
        }

        public void Update(TransferContato transferContato)
        {
            var contato = mapperContato.MapperTransferToEntity(transferContato);
            servicoContato.Update(contato);

        }
    }
}
