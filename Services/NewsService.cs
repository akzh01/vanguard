using System;
using System.Collections.Generic;
using Vanguard.Models;

namespace Vanguard.Services
{
    public interface NewsService
    {
        IEnumerable<News> GetAll();
        News Add(News news);
        void Delete(int id);
        News Get(int id);
    }
}
