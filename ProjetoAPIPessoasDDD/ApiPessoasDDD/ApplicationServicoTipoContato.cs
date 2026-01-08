using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Interfaces.Mapper;
using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Application
{
    public class ApplicationServicoTipoContato : IApplicationServicoTipoContato
    {
        private readonly IServicoTipoContato servicoTipoContato;
        private readonly IMapperTipoContato mapperTipoContato;
        public ApplicationServicoTipoContato(IServicoTipoContato servicoTipoContato, IMapperTipoContato mapperTipoContato)
        {
            this.servicoTipoContato = servicoTipoContato;
            this.mapperTipoContato = mapperTipoContato;
        }
        public void Add(TransferTipoContato transferTipoContato)
        {
            var Tipocontato = mapperTipoContato.MapperTransferToEntity(transferTipoContato);
            servicoTipoContato.Add(Tipocontato);
        }

        public TransferTipoContato GetById(int id)
        {
            var TipoContato = servicoTipoContato.GetById(id);
            return mapperTipoContato.MapperEntityToTransfer(TipoContato);
        }

        public IEnumerable<TransferTipoContato> GetAll()
        {
            var Tipocontato = servicoTipoContato.GetAll();
            return mapperTipoContato.MapperListTransferTipoContato(Tipocontato);
        }

        public void Remove(TransferTipoContato transferTipoContato)
        {
            var Tipocontato = mapperTipoContato.MapperTransferToEntity(transferTipoContato);
            servicoTipoContato.Remove(Tipocontato);
        }

        public void Update(TransferTipoContato transferTipoContato)
        {
            var Tipocontato = mapperTipoContato.MapperTransferToEntity(transferTipoContato);
            servicoTipoContato.Update(Tipocontato);

        }
    }
}
