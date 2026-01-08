using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPessoasDDD.Application.Interfaces.Mapper
{
    public class MapperEndereco : IMapperEndereco
    {
        IEnumerable<TransferEndereco>   transferEnderecos = new List<TransferEndereco>();
        public TransferEndereco MapperEntityToTransfer(Endereco endereco)
        {
            var transferEnderecos = new TransferEndereco()
            {
                Id = endereco.Id
                ,Longadouro = endereco.Longadouro
                ,Numero= endereco.Numero
                ,Bairro = endereco.Bairro
                ,Cidade = endereco.Cidade
                ,CEP = endereco.CEP
                ,TipoEndereco = endereco.TipoEndereco
                ,Ativo = endereco.Ativo
            };
            return transferEnderecos;
        }

        public IEnumerable<TransferEndereco> MapperListTransferEndereco(IEnumerable<Endereco> enderecos)
        {
            var Transfer = enderecos.Select(endereco => new TransferEndereco
            {
                Id = endereco.Id
                ,Longadouro = endereco.Longadouro
                ,Numero = endereco.Numero
                ,Bairro = endereco.Bairro
                ,Cidade = endereco.Cidade
                ,CEP = endereco.CEP
                ,TipoEndereco = endereco.TipoEndereco
                ,Ativo = endereco.Ativo
            });
            return Transfer;
        }

        public Endereco MapperTransferToEntity(TransferEndereco transferEndereco)
        {
            var endereco = new Endereco()
            {
                Id = transferEndereco.Id
                ,Longadouro = transferEndereco.Longadouro
                ,Numero = transferEndereco.Numero
                ,Bairro = transferEndereco.Bairro
                ,Cidade = transferEndereco.Cidade
                ,CEP = transferEndereco.CEP
                ,TipoEndereco = transferEndereco.TipoEndereco
                ,Ativo = transferEndereco.Ativo
              };
            return endereco;
        }
    }
}
