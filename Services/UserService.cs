using System;
using System.Collections.Generic;
using Vanguard.Models;

namespace Vanguard.Services
{
    public interface UserService
    {
        IEnumerable<Users> GetAll();
        Users Add(Users user);
        void Delete(int id);
        Users Get(int id);
    }
}
