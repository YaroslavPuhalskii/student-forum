using System;
using System.Threading.Tasks;

namespace StudentForum.DAL.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository GetUser { get; }

        IFileRepository GetFile { get; }

        ICommentRepository GetComment { get; }

        INewsRepository GetNews { get; }

        Task SaveAsync();
    }
}
