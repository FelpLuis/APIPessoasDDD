using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public interface IMapperTipoCliente
    {
        TipoCliente MapperTransferToEntity(TransferTipoCliente transferTipoCliente);
        IEnumerable<TransferTipoCliente> MapperListTransferTipoCliente(IEnumerable<TipoCliente> tiposClientes);
        TransferTipoCliente MapperEntityToTransfer(TipoCliente tipoCliente);

    }
}
