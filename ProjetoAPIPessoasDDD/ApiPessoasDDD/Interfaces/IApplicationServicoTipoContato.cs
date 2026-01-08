using APIPessoasDDD.Application.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces
{
    public interface IApplicationServicoTipoContato
    {
        void Add(TransferTipoContato transferTipoContato);
        void Update(TransferTipoContato transferTipoContato);
        void Remove(TransferTipoContato transferTipoContato);
        IEnumerable<TransferTipoContato> GetAll();
        TransferTipoContato GetById(int id);
    }
}
