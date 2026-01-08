using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Interfaces.Mapper;
using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;

namespace APIPessoasDDD.Application
{
    public class ApplicationServicoCliente : IApplicationServicoCliente
    {
        private readonly IServicoCliente servicoCliente;
        private readonly IMapperCliente mapperCliente;
        
        public ApplicationServicoCliente(IServicoCliente servicoCliente, IMapperCliente mapperCliente)
        {
            this.servicoCliente = servicoCliente;
            this.mapperCliente = mapperCliente;
        }
        public void Add(TransferCliente transferCliente)
        {
            var Cliente = mapperCliente.MapperTransferToEntity(transferCliente);
            servicoCliente.Add(Cliente);
        }

        public TransferCliente GetById(int id)
        {
            var cliente = servicoCliente.GetById(id);
            return mapperCliente.MapperEntityToTransfer(cliente);
        }

        public IEnumerable<TransferCliente> GetAll()
        {
            var cliente = servicoCliente.GetAll();
            return mapperCliente.MapperListTransferCliente(cliente);
        }

        public void Remove(TransferCliente transferCliente)
        {
            var cliente = mapperCliente.MapperTransferToEntity(transferCliente);
            servicoCliente.Remove(cliente);
        }

        public void Update(TransferCliente transferCliente)
        {
            var cliente = mapperCliente.MapperTransferToEntity(transferCliente);
            servicoCliente.Update(cliente);

        }
    }
}
