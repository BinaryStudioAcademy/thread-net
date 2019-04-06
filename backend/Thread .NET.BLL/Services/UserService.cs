using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class UserService : BaseService
    {
        public UserService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<ICollection<UserDTO>> GetUsers()
        {
            var users = await _context.Users
                .Include(x => x.Avatar)
                .ToListAsync();

            return _mapper.Map<ICollection<User>, ICollection<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserById(int id)
        {
            var user = await _context.Users
                .Include(u => u.Avatar)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                throw new NotFoundException(nameof(User), id);
            }

            return _mapper.Map<User, UserDTO>(user);
        }

        public async Task<UserDTO> CreateUser(UserDTO user)
        {
            var userEntity = _mapper.Map<UserDTO, User>(user);

            _context.Users.Add(userEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<User, UserDTO>(userEntity);
        }

        public async Task UpdateUser(UserDTO user)
        {
            var userEntity = _mapper.Map<UserDTO, User>(user);

            _context.Users.Update(userEntity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new NotFoundException(nameof(User), userId);
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
