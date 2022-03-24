using StudentForum.DAL.Abstractions;

namespace StudentForum.BL.Services
{
    public class BaseService
    {
        private readonly IUnitOfWork _unitOfWork;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork => _unitOfWork;
    }
}
