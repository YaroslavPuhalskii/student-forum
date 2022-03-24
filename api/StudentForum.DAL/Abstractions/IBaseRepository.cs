using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentForum.DAL.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        DbSet<T> GetDbSet { get; }

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(object id);

        void Insert(T obj);

        Task Delete(object id);

        void Delete(T obj);

        void Update(T obj);
    }
}
