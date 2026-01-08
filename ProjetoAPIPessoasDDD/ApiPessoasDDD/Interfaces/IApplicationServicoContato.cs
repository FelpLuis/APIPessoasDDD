using APIPessoasDDD.Application.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces
{
    public interface IApplicationServicoContato
    {
        void Add(TransferContato transferContato);
        void Update(TransferContato transferContato);
        void Remove(TransferContato transferContato);
        IEnumerable<TransferContato> GetAll();
        TransferContato GetById(int id);
    }
}
