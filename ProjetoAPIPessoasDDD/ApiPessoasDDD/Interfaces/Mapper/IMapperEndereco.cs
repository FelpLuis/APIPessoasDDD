using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public interface IMapperEndereco
    {
        Endereco MapperTransferToEntity(TransferEndereco transferEndereco);
        IEnumerable<TransferEndereco> MapperListTransferEndereco(IEnumerable<Endereco> enderecos);
        TransferEndereco MapperEntityToTransfer(Endereco endereco);

    }
}
