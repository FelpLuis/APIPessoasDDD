using APIPessoasDDD.Application.Transfer;

namespace APIPessoasDDD.Application.Interfaces
{
    public interface IApplicationServicoCliente
    {
        void Add(TransferCliente transferCliente);
        void Update(TransferCliente transferCliente);
        void Remove(TransferCliente transferCliente);
        IEnumerable<TransferCliente> GetAll();
        TransferCliente GetById(int id);
    }
}
