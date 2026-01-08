using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        IEnumerable<TransferCliente> transferClientes = new List<TransferCliente>();    
        public TransferCliente MapperEntityToTransfer(Cliente cliente)
        {
            var transferCliente = new TransferCliente()
            {
                Id = cliente.Id
                , Nome = cliente.Nome
                , TipoCliente = cliente.TipoCliente
                , Endereco = cliente.Endereco
                , Contato = cliente.Contato
                ,Ativo = cliente.Ativo
            };
            return transferCliente;
        }

        public IEnumerable<TransferCliente> MapperListTransferCliente(IEnumerable<Cliente> clientes)
        {
            var Transfer = clientes.Select(clientes => new TransferCliente {Id = clientes.Id
                ,Nome = clientes.Nome
                ,TipoCliente = clientes.TipoCliente
                ,Endereco = clientes.Endereco
                ,Contato = clientes.Contato
                ,Ativo = clientes.Ativo
            });
            return Transfer;
        }

        public Cliente MapperTransferToEntity(TransferCliente transferCliente)
        {
            var cliente = new Cliente()
            {
                Id = transferCliente.Id
                ,Nome = transferCliente.Nome
                ,TipoCliente = transferCliente.TipoCliente
                ,Endereco = transferCliente.Endereco
                ,Contato = transferCliente.Contato
                ,Ativo = transferCliente.Ativo  
            };
            return cliente;
        }
    }
}
