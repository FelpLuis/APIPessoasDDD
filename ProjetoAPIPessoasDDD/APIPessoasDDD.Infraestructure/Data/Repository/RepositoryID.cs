using APIPessoasDDD.Data;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using Microsoft.EntityFrameworkCore;

namespace APIPessoasDDD.Infraestructure.Data.Repository
{
    public class RepositoryID<TEntity>  :   IServicoID<TEntity> where TEntity : class 
    {
        private readonly PessoasDbContext pessoasDbContext;

        public RepositoryID(PessoasDbContext pessoasDbContext)
        {
            this.pessoasDbContext = pessoasDbContext;
        }
        public void Add(TEntity obj)
        {
            
            try
            {
                pessoasDbContext.Set<TEntity>().Add(obj);
                pessoasDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return pessoasDbContext.Set<TEntity>().ToList();   
        }

        public TEntity GetById(int id)
        {
            return pessoasDbContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                pessoasDbContext.Set<TEntity>().Remove(obj);
                pessoasDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                pessoasDbContext.Entry(obj).State = EntityState.Modified;
                pessoasDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
