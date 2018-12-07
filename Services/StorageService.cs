using System;
using System.Collections.Generic;
using Vanguard.Models;

namespace Vanguard.Services
{
    public interface StorageService
    {
        IEnumerable<Storage> GetAll();
        Storage Add(Storage storage);
        void Delete(int id);
        Storage Get(int id);
    }
}
