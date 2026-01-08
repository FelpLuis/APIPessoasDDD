using APIPessoasDDD.Application.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces
{
    public interface IApplicationServicoEndereco
    {
        void Add(TransferEndereco transferEndereco);
        void Update(TransferEndereco transferEndereco);
        void Remove(TransferEndereco transferEndereco);
        IEnumerable<TransferEndereco> GetAll();
        TransferEndereco GetById(int id);
    }
}
