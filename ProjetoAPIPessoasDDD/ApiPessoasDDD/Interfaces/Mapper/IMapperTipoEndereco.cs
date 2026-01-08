using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public interface IMapperTipoEndereco
    {
        TipoEndereco MapperTransferToEntity(TransferTipoEndereco transferTipoEndereco);
        IEnumerable<TransferTipoEndereco> MapperListTransferTipoEndereco(IEnumerable<TipoEndereco> tiposEnderecos);
        TransferTipoEndereco MapperEntityToTransfer(TipoEndereco tipoEndereco);

    }
}
