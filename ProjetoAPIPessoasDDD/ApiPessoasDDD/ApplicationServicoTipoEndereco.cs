using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Interfaces.Mapper;
using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Domain.Entitys;

namespace APIPessoasDDD.Application
{
    public class ApplicationServicoTipoEndereco : IApplicationServicoTipoEndereco
    {
        private readonly IServicoTipoEndereco servicoTipoEndereco;
        private readonly IMapperTipoEndereco mapperTipoEndereco;
        public ApplicationServicoTipoEndereco(IServicoTipoEndereco servicoTipoEndereco, IMapperTipoEndereco mapperTipoEndereco)
        {
            this.servicoTipoEndereco = servicoTipoEndereco;
            this.mapperTipoEndereco = mapperTipoEndereco;
        }
        public void Add(TransferTipoEndereco transferTipoEndereco)
        {
            var Tipoendereco = mapperTipoEndereco.MapperTransferToEntity(transferTipoEndereco);
            servicoTipoEndereco.Add(Tipoendereco);
        }

        public TransferTipoEndereco GetById(int id)
        {
            var Tipoendereco = servicoTipoEndereco.GetById(id);
            return mapperTipoEndereco.MapperEntityToTransfer(Tipoendereco);
        }

        public IEnumerable<TransferTipoEndereco> GetAll()
        {
            var Tipoendereco = servicoTipoEndereco.GetAll();
            return mapperTipoEndereco.MapperListTransferTipoEndereco(Tipoendereco);
        }

        public void Remove(TransferTipoEndereco transferTipoEndereco)
        {
            var Tipoendereco = mapperTipoEndereco.MapperTransferToEntity(transferTipoEndereco);
            servicoTipoEndereco.Remove(Tipoendereco);
        }

        public void Update(TransferTipoEndereco transferTipoEndereco)
        {
            var Tipoendereco = mapperTipoEndereco.MapperTransferToEntity(transferTipoEndereco);
            servicoTipoEndereco.Update(Tipoendereco);

        }
    }
}
