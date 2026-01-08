using APIPessoasDDD.Application.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces
{
    public interface IApplicationServicoTipoEndereco
    {
        void Add(TransferTipoEndereco transferTipoEndereco);
        void Update(TransferTipoEndereco transferTipoEndereco);
        void Remove(TransferTipoEndereco transferTipoEndereco);
        IEnumerable<TransferTipoEndereco> GetAll();
        TransferTipoEndereco GetById(int id);
    }
}
