using AutoMapper;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services.Abstract
{
    public abstract class BaseService
    {
        private protected readonly ThreadContext _context;
        private protected readonly IMapper _mapper;

        public BaseService(ThreadContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
