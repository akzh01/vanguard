using System;
using System.Collections.Generic;
using System.Linq;
using Vanguard.Data;
using Vanguard.Models;

namespace Vanguard.Services
{
    public class StorageServiceImpl : StorageService
    {
        private VanguardDbContext _context;

        public StorageServiceImpl(VanguardDbContext context)
        {
            _context = context;
        }

        public Storage Add(Storage storage)
        {
            _context.Storages.Add(storage);
            _context.SaveChanges();
            return storage;
        }

        public void Delete(int id)
        {
            _context.Storages.Remove(Get(id));
            _context.SaveChanges();
        }

        public Storage Get(int id)
        {
            return _context.Storages.FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<Storage> GetAll()
        {
            return _context.Storages.OrderBy(n => n.Id);
        }

    }
}
