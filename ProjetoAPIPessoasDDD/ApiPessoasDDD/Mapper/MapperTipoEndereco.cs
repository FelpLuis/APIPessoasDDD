using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public class MapperTipoEndereco : IMapperTipoEndereco
    {
        IEnumerable<TransferTipoEndereco> transferTipoEndereco = new List<TransferTipoEndereco>();
        public TransferTipoEndereco MapperEntityToTransfer(TipoEndereco tipoEndereco)
        {
            var transferTipoEndereco = new TransferTipoEndereco()
            {
                Id = tipoEndereco.Id
                ,
                Descricao = tipoEndereco.Descricao
                ,
                Ativo = tipoEndereco.Ativo
            };
            return transferTipoEndereco;
        }

        public IEnumerable<TransferTipoEndereco> MapperListTransferTipoEndereco(IEnumerable<TipoEndereco> tiposEnderecos)
        {
            var Transfer = tiposEnderecos.Select(tiposEnderecos => new TransferTipoEndereco
            {
                Id = tiposEnderecos.Id,
                Descricao = tiposEnderecos.Descricao,
                Ativo = tiposEnderecos.Ativo
            });
            return Transfer;
        }

        public TipoEndereco MapperTransferToEntity(TransferTipoEndereco transferTipoEndereco)
        {
            var tipoEndereco = new TipoEndereco()
            {
                Id = transferTipoEndereco.Id
                ,Descricao = transferTipoEndereco.Descricao
                ,Ativo = transferTipoEndereco.Ativo
            };
            return tipoEndereco;
        }
    }
}
