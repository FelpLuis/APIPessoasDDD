using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public class MapperContato : IMapperContato
    {
        IEnumerable<TransferContato> transferContatos = new List<TransferContato>();

        public TransferContato MapperEntityToTransfer(Contato contato)
        {
            var transferContato = new TransferContato()
            {
                Id = contato.Id
                ,TipoContato = contato.TipoContato
                ,DDD = contato.DDD
                ,Numero = contato.Numero
                ,Ativo = contato.Ativo 
            };
            return transferContato;
        }

        public IEnumerable<TransferContato> MapperListTransferContato(IEnumerable<Contato> contatos)
        {
            var Transfer = contatos.Select(contato => new TransferContato
            {
                Id = contato.Id
                ,TipoContato = contato.TipoContato
                ,DDD = contato.DDD
                ,Numero = contato.Numero
                ,Ativo = contato.Ativo
            });
            return Transfer;
        }

        public Contato MapperTransferToEntity(TransferContato transferContato)
        {
            var contato = new Contato()
            {
                Id = transferContato.Id
                ,TipoContato = transferContato.TipoContato
                ,DDD = transferContato.DDD
                ,Numero = transferContato.Numero
                ,Ativo = transferContato.Ativo
            };
            return contato;
        }
    }
}
