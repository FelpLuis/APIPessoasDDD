using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Interfaces.Mapper;
using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Application
{
    public class ApplicationServicoTipoCliente : IApplicationServicoTipoCliente
    {
        private readonly IServicoTipoCliente servicoTipoCliente;
        private readonly IMapperTipoCliente mapperTipoCliente;
        public ApplicationServicoTipoCliente(IServicoTipoCliente servicoTipoCliente, IMapperTipoCliente mapperTipoCliente)
        {
            this.servicoTipoCliente = servicoTipoCliente;
            this.mapperTipoCliente = mapperTipoCliente;
        }
        public void Add(TransferTipoCliente transferTipoCliente)
        {
            var TipoCliente = mapperTipoCliente.MapperTransferToEntity(transferTipoCliente);
            servicoTipoCliente.Add(TipoCliente);
        }

        public TransferTipoCliente GetById(int id)
        {
            var Tipocliente = servicoTipoCliente.GetById(id);
            return mapperTipoCliente.MapperEntityToTransfer(Tipocliente);
        }

        public IEnumerable<TransferTipoCliente> GetAll()
        {
            var Tipocliente = servicoTipoCliente.GetAll();
            return mapperTipoCliente.MapperListTransferTipoCliente(Tipocliente);
        }

        public void Remove(TransferTipoCliente transferTipoCliente)
        {
            var Tipocliente = mapperTipoCliente.MapperTransferToEntity(transferTipoCliente);
            servicoTipoCliente.Remove(Tipocliente);
        }

        public void Update(TransferTipoCliente transferTipoCliente)
        {
            var Tipocliente = mapperTipoCliente.MapperTransferToEntity(transferTipoCliente);
            servicoTipoCliente.Update(Tipocliente);

        }
    }
}
