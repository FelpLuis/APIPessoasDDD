using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public class MapperTipoCliente : IMapperTipoCliente
    {
        IEnumerable<TransferTipoCliente> transferTipoClientes = new List<TransferTipoCliente>();
        public TransferTipoCliente MapperEntityToTransfer(TipoCliente tipoCliente)
        {
            var transferTipoCliente = new TransferTipoCliente()
            {
                Id = tipoCliente.Id
                ,Descricao = tipoCliente.Descricao
                ,Ativo = tipoCliente.Ativo
            };
            return transferTipoCliente;
        }

        public IEnumerable<TransferTipoCliente> MapperListTransferTipoCliente(IEnumerable<TipoCliente> tiposClientes)
        {
            var Transfer = tiposClientes.Select(tipoCliente => new TransferTipoCliente
            {
                Id = tipoCliente.Id
                ,Descricao = tipoCliente.Descricao
                ,Ativo = tipoCliente.Ativo
            });
            return Transfer;
        }

        public TipoCliente MapperTransferToEntity(TransferTipoCliente transferTipoCliente)
        {
            var tipoCliente = new TipoCliente()
            {
                Id = transferTipoCliente.Id
                ,Descricao = transferTipoCliente.Descricao
                ,Ativo = transferTipoCliente.Ativo
            };
            return tipoCliente;
        }
    }
}
