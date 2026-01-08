using APIPessoasDDD.Application.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces
{
    public interface IApplicationServicoTipoCliente
    {
        void Add(TransferTipoCliente transferTipoCliente);
        void Update(TransferTipoCliente transferTipoCliente);
        void Remove(TransferTipoCliente transferTipoCliente);
        IEnumerable<TransferTipoCliente> GetAll();
        TransferTipoCliente GetById(int id);
    }
}
