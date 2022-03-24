using StudentForum.DAL.Abstractions;
using StudentForum.DAL.Repositories;
using StudentForum.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForum.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserRepository _userRepository;

        private IFileRepository _fileRepository;

        private ICommentRepository _commentRepository;

        private INewsRepository _newsRepository;

        private readonly EFContext _context;

        private bool disposedValue;

        public UnitOfWork()
        {
            _context = new EFContext();
        }

        public IUserRepository GetUser => _userRepository ??= new UserRepository(_context);

        public IFileRepository GetFile => _fileRepository ??= new FileRepository(_context);

        public ICommentRepository GetComment => _commentRepository ??= new CommentRepository(_context);

        public INewsRepository GetNews => _newsRepository ??= new NewsRepository(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
