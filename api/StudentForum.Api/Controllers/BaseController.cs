using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace StudentForum.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IMapper _mapper;

        protected BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected IMapper Mapper => _mapper;
    }
}
