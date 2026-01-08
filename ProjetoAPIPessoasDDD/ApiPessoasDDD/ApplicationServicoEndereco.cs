using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Interfaces.Mapper;
using APIPessoasDDD.Application.Transfer;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;

namespace APIPessoasDDD.Application
{
    public class ApplicationServicoEndereco : IApplicationServicoEndereco
    {
        private readonly IServicoEndereco servicoEndereco;
        private readonly IMapperEndereco mapperEndereco;
        public ApplicationServicoEndereco(IServicoEndereco servicoEndereco, IMapperEndereco mapperEndereco)
        {
            this.servicoEndereco = servicoEndereco;
            this.mapperEndereco = mapperEndereco;
        }
        public void Add(TransferEndereco transferEndereco)
        {
            var endereco = mapperEndereco.MapperTransferToEntity(transferEndereco);
            servicoEndereco.Add(endereco);
        }

        public TransferEndereco GetById(int id)
        {
            var endereco = servicoEndereco.GetById(id);
            return mapperEndereco.MapperEntityToTransfer(endereco);
        }

        public IEnumerable<TransferEndereco> GetAll()
        {
            var endereco = servicoEndereco.GetAll();
            return mapperEndereco.MapperListTransferEndereco(endereco);
        }

        public void Remove(TransferEndereco transferEndereco)
        {
            var endereco = mapperEndereco.MapperTransferToEntity(transferEndereco);
            servicoEndereco.Remove(endereco);
        }

        public void Update(TransferEndereco transferEndereco)
        {
            var endereco = mapperEndereco.MapperTransferToEntity(transferEndereco);
            servicoEndereco.Update(endereco);

        }
    }
}
