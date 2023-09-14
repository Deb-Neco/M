using MiniChef.Domain.IRepository;
using MiniChef.Domain.IService;
using MiniChef.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChef.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUserService(User user)
        {
            //criar a lógica para saber se o usuário existe 

            return await _userRepository.CreateUserRepository(user);
        }
    }
}
