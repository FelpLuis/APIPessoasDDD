using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public class MapperTipoContato : IMapperTipoContato
    {
        IEnumerable<TransferTipoContato> transferTipoContato = new List<TransferTipoContato>();

        public TransferTipoContato MapperEntityToTransfer(TipoContato tipoContato)
        {
            var transferTipoContato = new TransferTipoContato()
            {
                Id = tipoContato.Id
                ,Descricao = tipoContato.Descricao
                ,Ativo = tipoContato.Ativo
            };
            return transferTipoContato;
        }

        public IEnumerable<TransferTipoContato> MapperListTransferTipoContato(IEnumerable<TipoContato> tiposContatos)
        {
            var Transfer = tiposContatos.Select(tiposContatos => new TransferTipoContato
            {
                Id = tiposContatos.Id
                ,Descricao = tiposContatos.Descricao
                ,Ativo = tiposContatos.Ativo
            });
            return Transfer;
        }

        public TipoContato MapperTransferToEntity(TransferTipoContato transferTipoContato)
        {
            var tipoContato = new TipoContato()
            {
                Id = transferTipoContato.Id
                ,Descricao = transferTipoContato.Descricao
                ,Ativo = transferTipoContato.Ativo
            };
            return tipoContato;
        }
    }
}
