using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public interface IMapperTipoContato
    {
        TipoContato MapperTransferToEntity(TransferTipoContato transferTipoContato);
        IEnumerable<TransferTipoContato> MapperListTransferTipoContato(IEnumerable<TipoContato> tiposContatos);
        TransferTipoContato MapperEntityToTransfer(TipoContato tipoContato);

    }
}
