using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public interface IMapperContato
    {
        Contato MapperTransferToEntity(TransferContato transferContato);
        IEnumerable<TransferContato> MapperListTransferContato(IEnumerable<Contato> contatos);
        TransferContato MapperEntityToTransfer(Contato contato);

    }
}
