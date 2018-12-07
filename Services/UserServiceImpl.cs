using System;
using System.Collections.Generic;
using System.Linq;
using Vanguard.Data;
using Vanguard.Models;

namespace Vanguard.Services
{
    public class UserServiceImpl : UserService
    {
        private VanguardDbContext _context;

        public UserServiceImpl(VanguardDbContext context)
        {
            _context = context;
        }

        public Users Add(Users users)
        {
            _context.Users.Add(users);
            _context.SaveChanges();
            return users;
        }

        public void Delete(int id)
        {
            _context.Users.Remove(Get(id));
            _context.SaveChanges();
        }

        public Users Get(int id)
        {
            return _context.Users.FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<Users> GetAll()
        {
            return _context.Users.OrderBy(u => u.Id);
        }
    }
}
