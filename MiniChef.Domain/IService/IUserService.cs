using MiniChef.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChef.Domain.IService
{
    public interface IUserService
    {
        Task<User> CreateUserService(User user);
       
    }
}
