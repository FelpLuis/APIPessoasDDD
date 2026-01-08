using APIPessoasDDD.Domain.Core.Interfaces.Servicos;

namespace APIPessoasDDD.Domain.Services
{
    public class ServicoID<TEntity> : IServicoID<TEntity> where TEntity : class
    {
        private readonly IServicoID<TEntity> IServicoID;

        public ServicoID(IServicoID<TEntity> interfaceID)
        {
            this.IServicoID = interfaceID;
        }
        public void Add(TEntity obj)
        {
            IServicoID.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return IServicoID.GetAll();
        }

        public TEntity GetById(int id)
        {
            return IServicoID.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            IServicoID.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            IServicoID.Update(obj);
        }
    }
}
