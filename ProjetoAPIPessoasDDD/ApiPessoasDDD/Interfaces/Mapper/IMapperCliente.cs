using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System.Collections.Generic;


namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public interface IMapperCliente
    {
        Cliente MapperTransferToEntity(TransferCliente transferCliente);
        IEnumerable<TransferCliente> MapperListTransferCliente(IEnumerable<Cliente> clientes);
        TransferCliente MapperEntityToTransfer(Cliente cliente);

    }
}
