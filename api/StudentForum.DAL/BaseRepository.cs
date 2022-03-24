using Microsoft.EntityFrameworkCore;
using StudentForum.DAL.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentForum.DAL
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _context;

        private readonly DbSet<T> _dbSet;

        public DbSet<T> GetDbSet => _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Delete(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"{nameof(obj)} is null!");
            }

            if (_context.Entry(obj).State == EntityState.Detached)
            {
                _dbSet.Attach(obj);
            }

            _dbSet.Remove(obj);
        }

        public async Task Delete(object id)
        {
            if (id == null)
            {
                throw new ArgumentNullException($"{nameof(id)} is null!");
            }

            T entity = await _dbSet.FindAsync(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(object id)
        {
            if (id == null)
            {
                throw new ArgumentNullException($"{nameof(id)} is null!");
            }

            return await _dbSet.FindAsync(id);
        }

        public void Insert(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"{nameof(obj)} is null!");
            }

            _dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"{nameof(obj)} is null!");
            }

            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
